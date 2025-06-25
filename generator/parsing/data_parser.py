from __future__ import annotations

import copy
import inspect
from typing import TYPE_CHECKING

from ruamel.yaml.scalarint import HexInt

from parsing.util import UNMAPPED_SYMBOLS, normalize_name

if TYPE_CHECKING:
    from parsing.headers.header_mapping import HeaderMapping


class DataParser:
    def __init__(
        self,
        binary_name: str,
        version: str,
        base_address: int,
        header_mapping: HeaderMapping,
        *,
        is_subregion: bool,
    ) -> None:
        self.binary_name = binary_name
        self.version = version
        self.base_address = base_address
        self.header_mapping = header_mapping
        self.is_subregion = is_subregion
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
        if type_lookup_name in self.header_mapping.extern_map:
            type_name = self.header_mapping.extern_map[type_lookup_name]
        else:
            # We should not continue when this occurs as all symbols should be mapped in some fashion.
            self._print_err(
                f"Type mapping is missing for '{type_lookup_name}'.",
            )
            raise ValueError

        # Store the data we know so far.
        data_entry = {
            # Kaitai streams use relative positioning.
            "pos": HexInt(data["address"][self.version] - self.base_address),
            "type": type_name,
        }

        # Add the docstrings from pmdsky-debug if they exist.
        data_entry["doc"] = data.get("description") or "This symbol is missing documentation."

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
            import_path = f"../types/{import_file_name}"
            if self.is_subregion:
                import_path = "../" + import_path
            self.imports.append(import_path)

        return data_entry

    def _process_raw_data(
        self,
        symbol_name: str,
        address: HexInt,
        docs: str | None,
        length: int | None,
    ) -> dict | None:
        self._print_warn(
            f"Attempting to map explicitly defined raw data '{symbol_name}'...",
        )
        if not length:
            self._print_warn(
                "Skipping, this data symbol does not have a documented length.",
            )
            return None

        return {
            "pos": address,
            "type": "u1",
            "repeat": "expr",
            "repeat-expr": length,
            "doc": docs or "This symbol is missing documentation.",
        }

    def process_data(  # noqa: C901
        self,
        data_list: list[dict],
    ) -> dict:
        failed_entries = []
        data_entries = {}
        for data in data_list:
            if "address" not in data or self.version not in data["address"]:
                self._print_warn("Version", self.version, "does not have a documented address for", data["name"])
                continue

            extern_name = self.header_mapping.extern_name_map.get(data["name"])
            if not extern_name:
                if data["name"] in UNMAPPED_SYMBOLS:
                    normalized_name = normalize_name(data["name"])
                    address = HexInt(data["address"][self.version] - self.base_address)
                    docs = data.get("description")
                    data_length = (
                        data["length"][self.version] if "length" in data and self.version in data["length"] else None
                    )
                    raw_data_entry = self._process_raw_data(
                        normalized_name,
                        address,
                        docs,
                        data_length,
                    )
                    if raw_data_entry:
                        data_entries[normalized_name] = raw_data_entry
                else:
                    failed_entries.append(data["name"])
                continue

            if isinstance(data["address"][self.version], list):
                for i, data_address in enumerate(data["address"][self.version]):
                    current_data_name = f"{extern_name}_{i}"
                    data_copy = copy.deepcopy(data)
                    data_copy["address"][self.version] = data_address
                    data_entry = self._build_data_entry(data_copy, extern_name)
                    if data_entry:
                        data_entries[current_data_name] = data_entry
            else:
                data_entry = self._build_data_entry(data, extern_name)
                if data_entry:
                    data_entries[extern_name] = data_entry

        if len(failed_entries) > 0:
            self._print_err(
                "Failed to find a mapping for the following",
                f"{len(failed_entries)} symbol(s) in {self.binary_name}:\n{'\n'.join(failed_entries)}",
                "\nUnknown symbols must be explicitly ignored if the data headers do not document this data entry.",
                "This is to ensure that the header parser does not have errors.",
            )
            raise ValueError

        return {
            "meta": {
                "id": f"{self.binary_name}_data",
                "endian": "le",
                "imports": self.imports,
            },
            "instances": data_entries,
        }
