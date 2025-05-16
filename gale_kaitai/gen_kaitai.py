from pathlib import Path

import ruamel.yaml

from data_parser import DataParser
from function_parser import FunctionParser

SYMBOL_DIR = "_pmdsky-debug/symbols"


def process_subregion(
    parent_binary: str,
    subregion_file_name: str,
    version: str,
) -> None:
    subregion_path = Path(SYMBOL_DIR, parent_binary, subregion_file_name)
    if not subregion_path.exists():
        print(f"[ERROR][{parent_binary}][{version}][process_subregion]: File not found {subregion_file_name}.")
        raise ValueError

    with subregion_path.open() as f:
        subregion_yaml = yaml.load(f)
        process_binary_version(subregion_yaml, subregion_path.stem, version, Path("src", version, "subregions"))


def process_binary_version(
    root_dict: dict,
    binary_name: str,
    version: str,
    destination: Path,
) -> None:
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

        function_map = FunctionParser(binary_name, version, base_address).process_functions(
            root_dict[binary_name]["functions"],
        )

        function_folder = Path(destination, "functions")
        function_folder.mkdir(parents=True, exist_ok=True)
        with Path(function_folder, f"{function_map_type_name}.ksy").open("w") as f:
            yaml.dump(function_map, f)
            f.flush()

    if "data" in root_dict[binary_name] and len(root_dict[binary_name]["data"]) > 0:
        data_map_type_name = f"{binary_name}_data"
        result_dict["meta"]["imports"].append(f"data/{data_map_type_name}")
        result_dict["instances"]["data"] = {}
        result_dict["instances"]["data"]["type"] = data_map_type_name

        data_map = DataParser(binary_name, version, base_address).process_data(root_dict[binary_name]["data"])
        data_folder = Path(destination, "data")
        data_folder.mkdir(parents=True, exist_ok=True)
        with Path(data_folder, f"{data_map_type_name}.ksy").open("w") as f:
            yaml.dump(data_map, f)
            f.flush()

    if "subregions" in root_dict[binary_name]:
        subregion: str
        for subregion in root_dict[binary_name]["subregions"]:
            process_subregion(binary_name, subregion, version)
            result_dict["meta"]["imports"].append(f"subregions/{subregion.removesuffix('.yml')}")
            result_dict["instances"][subregion.removesuffix(".yml")] = {
                "type": subregion.removesuffix(".yml"),
            }

    destination.mkdir(parents=True, exist_ok=True)
    with Path(destination, f"{binary_name}.ksy").open("w") as f:
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
                process_binary_version(current_yaml, binary_name, version, Path("src", version))
