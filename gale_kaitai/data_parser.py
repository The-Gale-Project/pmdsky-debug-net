import re
from pathlib import Path

from ruamel.yaml.scalarint import HexInt

DATA_HEADER_DIR = "_pmdsky-debug/headers/data"

KSY_TYPE_MAP = {
    "uint8_t": "u1",
    "uint16_t": "u2",
    "uint32_t": "u4",
    "uint64_t": "u8",
    "int8_t": "s1",
    "int16_t": "s2",
    "int32_t": "s4",
    "int64_t": "s8",
    "char": "s1",
    "short": "s2",
    "int": "s4",
    "uint": "u4",
    "long": "s8",
    "float": "f4",
    "double": "f8",
    "WORD": "u2",
    "DWORD": "u4",
    "__s32": "s4",
    "__s64": "s8",
    # Special pmdsky_debug typedefs
    "undefined": "u1",
    "undefined1": "u1",
    "undefined2": "u2",
    "undefined4": "u4",
    "fx32_16": "s4",
    "fx32_12": "s4",
    "fx32_8": "s4",
    "fx16_14": "s2",
    "ufx32_16": "s4",
    "ufx32_8": "s4",
    "render_3d_element_fn_t": "u4",  # Pointer
}

KSY_STRUCT_MAP = {}
KSY_ENUM_MAP = {}


class DataParser:
    def __init__(
        self,
        binary_name: str,
        base_address: int,
        version: str,
    ) -> None:
        self.binary_name = binary_name
        self.base_address = base_address
        self.version = version
        self.types = {}
        self.array_types = {}

    def build_type_map(self) -> dict:
        result_dict = {}
        for header_path in Path(DATA_HEADER_DIR).rglob("*.h"):
            with header_path.open("r") as f:
                for line in f:
                    # Ignore comments.
                    line = re.sub(r"[\s]*//.+", "", line)  # noqa: PLW2901

                    if not line.startswith("extern"):
                        continue

                    identifiers = line.split(" ")
                    line_primitive = identifiers[1]
                    line_type_name_search = re.search(r"[_A-Z0-9]+", identifiers[-1])
                    if not line_type_name_search:
                        print(f"[WARNING][build_type_map][{header_path}]: Invalid line:\n", line)
                        continue

                    line_type_name = line_type_name_search.group().lower().replace("__", "_")

                    line_array_length_search = re.search(r"\[([0-9]+)\]", identifiers[-1])
                    if line_array_length_search:
                        if line_type_name in self.array_types:
                            print(f"[ERROR][build_type_map][{header_path}]:", line_type_name, "is already defined.")
                            raise ValueError
                        self.array_types[line_type_name] = int(line_array_length_search.group(1))

                    if line_primitive == "struct":
                        line_struct = identifiers[2]
                        if line_struct in KSY_STRUCT_MAP:
                            result_dict[line_type_name] = line_struct
                        elif line_struct.endswith("*"):
                            # This is a pointer.
                            result_dict[line_type_name] = "u4"
                        else:
                            print(
                                f"[WARNING][build_type_map][{header_path}]: Failed to find struct mapping",
                                line_struct,
                                "for",
                                line_type_name,
                            )
                    elif line_primitive == "enum":
                        line_enum = identifiers[2]
                        if line_enum in KSY_ENUM_MAP:
                            result_dict[line_type_name] = line_enum
                        else:
                            print(
                                f"[WARNING][build_type_map][{header_path}]: Failed to find enum mapping",
                                line_enum,
                                "for",
                                line_type_name,
                            )
                    elif line_primitive in KSY_TYPE_MAP:
                        result_dict[line_type_name] = KSY_TYPE_MAP[line_primitive]
                    elif line_primitive.endswith("*"):
                        # This is a pointer.
                        result_dict[line_type_name] = "u4"
                    else:
                        # Ensure we don't store this.
                        result_dict.pop(line_type_name, None)
                        print(
                            f"[WARNING][build_type_map][{header_path}]: Failed to map type",
                            line_primitive,
                            "for",
                            line_type_name,
                        )

        return result_dict

    def process_data(
        self,
        data_list: list[dict],
        type_map: dict,
    ) -> dict:
        result_dict = {}
        for data in data_list:
            if "address" not in data or self.version not in data["address"]:
                continue

            data_name = data["name"].lower().replace("__", "_")

            if isinstance(data["address"][self.version], list):
                pass
            else:
                if ("length" not in data or self.version not in data["length"]) and data_name not in type_map:
                    print(
                        f"[WARNING][{self.version}]: Type mapping is required for",
                        data_name,
                        "since it has no documented length.",
                    )
                    continue

                result_dict[data_name] = {
                    "pos": HexInt(data["address"][self.version] - self.base_address),
                }

                if "description" in data:
                    result_dict[data_name]["doc"] = data["description"]

                if data_name in type_map:
                    result_dict[data_name]["type"] = type_map[data_name]

                    if data_name in self.array_types:
                        if self.array_types[data_name] == 0:
                            if "length" not in data or self.version not in data["length"]:
                                print(
                                    f"[WARNING][{self.version}]: Skipping",
                                    data_name,
                                    "due to it being a variable length array,",
                                    "but there is not a length associated with it.",
                                )
                                result_dict.pop(data_name, None)
                                continue
                            result_dict[data_name]["size"] = HexInt(data["length"][self.version])
                            result_dict[data_name]["type"] = f"{data_name}_entries"
                            self.types[f"{data_name}_entries"] = {
                                "seq": [
                                    {
                                        "id": "entries",
                                        "type": type_map[data_name],
                                        "repeat": "eos",
                                    },
                                ],
                            }
                        else:
                            result_dict[data_name]["repeat"] = "expr"
                            result_dict[data_name]["repeat-expr"] = self.array_types[data_name]
                else:
                    result_dict[data_name]["size"] = HexInt(data["length"][self.version])

        return result_dict
