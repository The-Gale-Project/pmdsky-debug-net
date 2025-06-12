import re

import ruamel.yaml

C_TYPE_MAP = {
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
    "size_t": "u4",
    "wchar_t": "u2",
    "__s32": "s4",
    "__s64": "s8",
}

HEADER_DIR = "_pmdsky-debug/headers"
SYMBOL_DIR = "_pmdsky-debug/symbols"

OUTPUT_DIR = "../gale_kaitai"

yaml = ruamel.yaml.YAML()


def normalize_name(name: str) -> str:
    return re.sub(r"[\s]+", "_", name.strip().lower().lstrip("_"))


def to_snake_case(s: str) -> str:
    # Replace hyphens with spaces, then apply regular expression substitutions for title case conversion
    # and add an underscore between words, finally convert the result to lowercase
    return "_".join(re.sub("([A-Z][a-z]+)", r" \1", re.sub("([A-Z]+)", r" \1", s.replace("-", " "))).split()).lower()
