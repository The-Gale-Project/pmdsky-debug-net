from ruamel.yaml.scalarint import HexInt
from util import to_snake_case


class FunctionParser:
    def __init__(
        self,
        binary_name: str,
        version: str,
        base_address: int,
    ) -> None:
        self.binary_name = binary_name
        self.version = version
        self.base_address = base_address

    def _build_function_entry(
        self,
        function: dict,
    ) -> dict:
        function_entry = {
            "value": HexInt(function["address"][self.version] - self.base_address),
        }

        if "description" in function:
            function_entry["doc"] = function["description"]

        return function_entry

    def process_functions(
        self,
        function_list: list[dict],
    ) -> dict:
        function_entries = {}
        for function in function_list:
            if "address" not in function or self.version not in function["address"]:
                continue

            function_name = to_snake_case(function["name"]).strip("_")

            if isinstance(function["address"][self.version], list):
                pass
            else:
                function_entries[function_name] = self._build_function_entry(function)

        return {
            "doc": f"List of functions within {self.binary_name.upper()} with "
            "relative address locations as their values.",
            "meta": {
                "id": f"{self.binary_name}_functions",
                "endian": "le",
            },
            "instances": function_entries,
        }
