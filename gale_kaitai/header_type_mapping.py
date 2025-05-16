import re
from pathlib import Path

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

TYPE_HEADER_DIR = "_pmdsky-debug/headers/types"

REGEX_BODY = re.compile(r"\s*([A-Za-z0-9_]+)\s+([A-Za-z0-9_]+)\s*;\s*(\/\*\s*(.*?)\s*\*\/)?")
REGEX_STRUCT = re.compile(r"struct\s+([A-Za-z0-9_]+)?\s*\{(.*?)\}\s*(.*?);", re.DOTALL)


class HeaderTypeMapping:
    @staticmethod
    def _parse_body(body: str) -> list:
        r = []
        for match in REGEX_BODY.finditer(body):
            type_name, name, _, comment_body = match.groups()
            h = {"id": name, "type": KSY_TYPE_MAP.get(type_name, type_name)}
            if comment_body and comment_body.strip():
                h["doc"] = comment_body
            r.append(h)
        return r

    @staticmethod
    def build_type_map() -> dict:
        result = {}
        for header_file in Path(TYPE_HEADER_DIR).rglob("*.h"):
            with header_file.open() as f:
                header_text = f.read()
            for match in REGEX_STRUCT.finditer(header_text):
                tag, body, name = match.groups()
                name = name.split(",")[0].strip()
                name = name if name else tag
                result[name] = HeaderTypeMapping._parse_body(body)
        return result
