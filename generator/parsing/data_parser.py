from __future__ import annotations

import copy
import inspect

from generator.parsing.headers.header_mapping import HeaderMapping
from ruamel.yaml.scalarint import HexInt


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
        self.header_mapping = HeaderMapping(version)
        self.imports = []

    @classmethod
    def _print_warn(cls, *values: object) -> None:
        current_frame = inspect.currentframe()
        current_frame_back = current_frame.f_back if current_frame else None
        if not current_frame or not current_frame_back:
            print(f"[WARNING][{cls.__name__}]:", *values)
            return

        print(f"[WARNING][{cls.__name__}][{current_frame_back.f_code.co_name}]:", *values)

    @classmethod
    def _print_err(cls, *values: object) -> None:
        current_frame = inspect.currentframe()
        current_frame_back = current_frame.f_back if current_frame else None
        if not current_frame or not current_frame_back:
            print(f"[ERROR][{cls.__name__}]:", *values)
            return

        print(f"[ERROR][{cls.__name__}][{current_frame_back.f_code.co_name}]:", *values)

    def _build_data_entry(
        self,
        data: dict,
        type_lookup_name: str,
    ) -> dict | None:
        # Ensure this symbol is mapped.
        if type_lookup_name in self.header_mapping.extern_name_map:
            normalized_symbol_name = self.header_mapping.extern_name_map[type_lookup_name]
            type_name = self.header_mapping.extern_map[normalized_symbol_name]
        else:
            # We should not continue when this occurs as all symbols should be mapped in some fashion.
            self._print_err(
                "Type mapping is required for",
                type_lookup_name,
                "since it has no documented length.",
            )
            raise ValueError

        # Store the data we know so far.
        data_entry = {
            # Kaitai streams use relative positioning.
            "pos": HexInt(data["address"][self.version] - self.base_address),
            "type": type_name,
        }

        # Add the docstrings from pmdsky-debug if they exist.
        if "description" in data:
            data_entry["doc"] = data["description"]

        if type_name not in self.header_mapping.import_map:
            self._print_err(
                "Failed to find mapping for",
                type_name,
                "within the import mapping.",
            )
            raise ValueError

        # Retrieve the imports needed to load this type.
        import_file_name = self.header_mapping.import_map[type_name]

        # Ensure the file name is not None.
        # None file names indicate it's a built-in Kaitai Struct type.
        if import_file_name and import_file_name not in self.imports:
            self.imports.append(f"../types/{import_file_name}")

        return data_entry

    def process_data(
        self,
        data_list: list[dict],
    ) -> dict:
        data_entries = {}
        for data in data_list:
            if "address" not in data or self.version not in data["address"]:
                self._print_warn("Version", self.version, "does not have a documented address for", data["name"])
                continue

            data_name = self.header_mapping.extern_name_map.get(data["name"])

            if not data_name:
                self._print_err(
                    "Failed to find a mapping for",
                    data["name"],
                    "\n\tAn exception must be made if the data headers do not document this data entry.",
                    "This is to ensure that the header parser does not have errors.",
                )
                raise ValueError

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
                "imports": self.imports,
            },
            "instances": data_entries,
        }
