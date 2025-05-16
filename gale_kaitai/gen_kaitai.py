import re
from pathlib import Path

import ruamel.yaml
from ruamel.yaml.scalarint import HexInt

from data_parser import DataParser

SYMBOL_DIR = "_pmdsky-debug/symbols"


def to_snake_case(s: str) -> str:
    # Replace hyphens with spaces, then apply regular expression substitutions for title case conversion
    # and add an underscore between words, finally convert the result to lowercase
    return "_".join(re.sub("([A-Z][a-z]+)", r" \1", re.sub("([A-Z]+)", r" \1", s.replace("-", " "))).split()).lower()


def process_functions(function_list: list[dict], base_address: int, version_id: str) -> dict:
    result_dict = {}
    for function in function_list:
        if "address" not in function or version_id not in function["address"]:
            continue

        function_name = to_snake_case(function["name"]).strip("_")

        if isinstance(function["address"][version_id], list):
            # TODO(DeltaJordan): Figure out how to handle address lists.
            pass
        else:
            result_dict[function_name] = {
                "value": HexInt(function["address"][version_id] - base_address),
            }

            if "description" in function:
                result_dict[function_name]["doc"] = function["description"]

    return result_dict


def process_binary_version(root_dict: dict, binary_name: str, version: str) -> dict:
    result_dict = {}

    # Get base address
    if "address" in root_dict[binary_name] and version in root_dict[binary_name]["address"]:
        base_address: int = root_dict[binary_name]["address"][version]
    else:
        print(
            f"[ERROR][{binary_name}][{version}]: Could not find base address for binary",
            binary_name,
            "using version",
            version,
        )
        raise ValueError

    # Add docstring
    if "description" in root_dict[binary_name]:
        result_dict["doc"] = root_dict[binary_name]["description"]

    # Build metadata
    result_dict["meta"] = {
        "id": binary_name,
        "tags": version,
        "endian": "le",
        "imports": ["../common/types"],
    }

    result_dict["meta"]["imports"] = []

    # Build address data
    result_dict["instances"] = {}
    if "functions" in root_dict[binary_name] and len(root_dict[binary_name]["functions"]) > 0:
        function_map_type_name = f"{binary_name}_functions"
        result_dict["meta"]["imports"].append(f"functions/{function_map_type_name}")
        result_dict["instances"]["functions"] = {
            "type": function_map_type_name,
        }

        function_map = {
            "doc": f"List of functions within {binary_name.upper()} with relative address locations as their values.",
        }
        function_map["meta"] = {
            "id": function_map_type_name,
            "endian": "le",
        }
        function_map["instances"] = process_functions(
            root_dict[binary_name]["functions"],
            base_address,
            version,
        )

        function_folder = Path("src", f"{version}", "functions")
        function_folder.mkdir(parents=True, exist_ok=True)
        with Path(function_folder, f"{function_map_type_name}.ksy").open("w") as f:
            yaml.dump(function_map, f)
            f.flush()

    if "data" in root_dict[binary_name] and len(root_dict[binary_name]["data"]) > 0:
        data_map_type_name = f"{binary_name}_data"
        result_dict["meta"]["imports"].append(f"data/{data_map_type_name}")
        result_dict["instances"]["data"] = {}
        result_dict["instances"]["data"]["type"] = data_map_type_name

        data_map = DataParser(binary_name, base_address, version).process_data(root_dict[binary_name]["data"])
        data_folder = Path("src", version, "data")
        data_folder.mkdir(parents=True, exist_ok=True)
        with Path(data_folder, f"{data_map_type_name}.ksy").open("w") as f:
            yaml.dump(data_map, f)
            f.flush()

    if "subregions" in root_dict[binary_name]:
        # TODO(DeltaJordan): Figure out how to handle subregions.
        pass

    mapping_folder = Path("src", version)
    mapping_folder.mkdir(parents=True, exist_ok=True)
    with Path(mapping_folder, f"{binary_name}.ksy").open("w") as f:
        yaml.dump(result_dict, f)
        f.flush()


if __name__ == "__main__":
    yaml = ruamel.yaml.YAML()

    for yaml_path in Path(SYMBOL_DIR).glob("*.yml"):
        with yaml_path.open("r") as f:
            current_yaml = yaml.load(f)
            binary_name = next(iter(current_yaml.keys()))
            for version in current_yaml[binary_name]["versions"]:
                if version in ["EU", "NA", "JP"]:
                    result = process_binary_version(current_yaml, binary_name, version)
