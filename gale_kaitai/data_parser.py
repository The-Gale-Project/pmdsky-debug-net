from __future__ import annotations

import copy
import re
from pathlib import Path

from ruamel.yaml.scalarint import HexInt

from header_type_mapping import KSY_TYPE_MAP, HeaderTypeMapping

DATA_HEADER_DIR = "_pmdsky-debug/headers/data"

KSY_STRUCT_MAP = HeaderTypeMapping.build_type_map()
KSY_ENUM_MAP = {}


class DataParser:
    def __init__(
        self,
        binary_name: str,
        version: str,
        base_address: int,
    ) -> None:
        self.binary_name = binary_name
        self.version = version
        self.base_address = base_address
        self.type_map = {}
        self.array_types = {}
        self.used_structs = {}
        self.used_enums = {}
        self._build_type_map()

    def _parse_struct(self, struct_name: str, data_name: str) -> None:
        if struct_name in KSY_STRUCT_MAP:
            self.type_map[data_name] = struct_name
            self.used_structs[struct_name] = KSY_STRUCT_MAP[struct_name]
        elif struct_name.endswith("*"):
            # This is a pointer.
            self.type_map[data_name] = "u4"
        else:
            print(
                f"[WARNING][build_type_map][{self.binary_name}]: Failed to find struct mapping",
                struct_name,
                "for",
                data_name,
            )

    def _parse_enum(self, enum_name: str, data_name: str) -> None:
        if enum_name in KSY_ENUM_MAP:
            self.type_map[data_name] = enum_name
            self.used_enums[enum_name] = KSY_ENUM_MAP[enum_name]
        elif enum_name.endswith("*"):
            # This is a pointer.
            self.type_map[enum_name] = "u4"
        else:
            print(
                f"[WARNING][build_type_map][{self.binary_name}]: Failed to find enum mapping",
                enum_name,
                "for",
                data_name,
            )

    def _parse_header(self, header_path: Path) -> None:
        with header_path.open("r") as f:
            for line in f:
                # Ignore comments.
                line = re.sub(r"[\s]*//.+", "", line)  # noqa: PLW2901

                if not line.startswith("extern"):
                    continue

                identifiers = line.split(" ")
                line_primitive = identifiers[1]
                data_name_search = re.search(r"[_A-Z0-9]+", identifiers[-1])
                if not data_name_search:
                    print(f"[WARNING][build_type_map][{header_path}]: Invalid line:\n", line)
                    continue

                data_name = data_name_search.group().lower().replace("__", "_")

                line_array_length_search = re.search(r"\[([0-9]+)\]", identifiers[-1])
                if line_array_length_search:
                    if data_name in self.array_types:
                        print(f"[ERROR][build_type_map][{header_path}]:", data_name, "is already defined.")
                        raise ValueError
                    self.array_types[data_name] = int(line_array_length_search.group(1))

                if line_primitive == "struct":
                    self._parse_struct(identifiers[2], data_name)
                elif line_primitive == "enum":
                    self._parse_enum(identifiers[2], data_name)
                elif line_primitive in KSY_TYPE_MAP:
                    self.type_map[data_name] = KSY_TYPE_MAP[line_primitive]
                elif line_primitive.endswith("*"):
                    # This is a pointer.
                    self.type_map[data_name] = "u4"
                else:
                    self.type_map.pop(data_name, None)
                    print(
                        f"[WARNING][build_type_map][{header_path}]: Failed to map type",
                        line_primitive,
                        "for",
                        data_name,
                    )

    def _get_header_file_name(self) -> str:
        header_file_name = f"{self.binary_name}.h"
        if self.binary_name == "overlay1":
            header_file_name = "overlay01.h"
        elif self.binary_name == "overlay9":
            header_file_name = "overlay09.h"
        elif self.binary_name == "itcm":
            header_file_name = "arm9/itcm.h"
        elif self.binary_name == "move_effects":
            header_file_name = "overlay29/move_effects.h"

        return header_file_name

    def _build_type_map(self) -> None:
        header_path = Path(DATA_HEADER_DIR, self._get_header_file_name())
        if not header_path.exists():
            if self.binary_name in ["overlay26", "overlay30"]:
                # At the time of writing, these overlays do not have a header file.
                return
            print(f"[ERROR][build_type_map][{self.binary_name}]: Failed to read header file, does not exist.")
            raise ValueError
        self._parse_header(header_path)

        if self.binary_name == "arm9":
            itcm_path = Path(DATA_HEADER_DIR, "arm9", "itcm.h")
            if not itcm_path.exists():
                print("[ERROR][build_type_map][itcm]: Failed to read header file, does not exist.")
                raise ValueError

            self._parse_header(itcm_path)
        elif self.binary_name == "overlay29":
            move_effects_path = Path(DATA_HEADER_DIR, "overlay29", "move_effects.h")
            if not move_effects_path.exists():
                print("[ERROR][build_type_map][move_effects]: Failed to read header file, does not exist.")
                raise ValueError

            self._parse_header(move_effects_path)

    def _build_data_entry(
        self,
        data: dict,
        type_lookup_name: str,
    ) -> dict | None:
        if ("length" not in data or self.version not in data["length"]) and type_lookup_name not in self.type_map:
            print(
                f"[WARNING][{self.version}]: Type mapping is required for",
                type_lookup_name,
                "since it has no documented length.",
            )
            return None

        data_entry = {
            "pos": HexInt(data["address"][self.version] - self.base_address),
        }

        if "description" in data:
            data_entry["doc"] = data["description"]

        if type_lookup_name in self.type_map:
            data_entry["type"] = self.type_map[type_lookup_name]

            if type_lookup_name in self.array_types:
                if self.array_types[type_lookup_name] == 0:
                    if "length" not in data or self.version not in data["length"]:
                        print(
                            f"[WARNING][{self.version}]: Skipping",
                            type_lookup_name,
                            "due to it being a variable length array,",
                            "but there is not a length associated with it.",
                        )
                        return None
                    data_entry["size"] = HexInt(data["length"][self.version])
                    data_entry["type"] = f"{type_lookup_name}_entries"
                    if f"{type_lookup_name}_entries" not in self.used_structs:
                        self.used_structs[f"{type_lookup_name}_entries"] = {
                            "seq": [
                                {
                                    "id": "entries",
                                    "type": self.type_map[type_lookup_name],
                                    "repeat": "eos",
                                },
                            ],
                        }
                else:
                    data_entry["repeat"] = "expr"
                    data_entry["repeat-expr"] = self.array_types[type_lookup_name]
        else:
            data_entry["size"] = HexInt(data["length"][self.version])

        return data_entry

    def process_data(
        self,
        data_list: list[dict],
    ) -> dict:
        data_entries = {}
        for data in data_list:
            if "address" not in data or self.version not in data["address"]:
                continue

            data_name = data["name"].lower().replace("__", "_")

            if isinstance(data["address"][self.version], list):
                for i, data_address in enumerate(data["address"][self.version]):
                    current_data_name = f"{data_name}_{i}"
                    data_copy = copy.deepcopy(data)
                    data_copy["address"][self.version] = data_address
                    data_entry = self._build_data_entry(data_copy, data_name)
                    if data_entry:
                        data_entries[current_data_name] = data_entry
            else:
                data_entry = self._build_data_entry(data, data_name)
                if data_entry:
                    data_entries[data_name] = data_entry

        return {
            "meta": {
                "id": f"{self.binary_name}_data",
                "endian": "le",
            },
            "instances": data_entries,
            "types": self.used_structs,
            "enums": self.used_enums,
        }
