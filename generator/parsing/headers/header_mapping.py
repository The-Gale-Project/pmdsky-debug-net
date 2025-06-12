from __future__ import annotations

import inspect
import re
from pathlib import Path

from pycparser import parse_file
from pycparser.c_ast import (
    ArrayDecl,
    BinaryOp,
    Constant,
    Decl,
    Enum,
    Enumerator,
    EnumeratorList,
    FuncDecl,
    IdentifierType,
    Pragma,
    PtrDecl,
    StaticAssert,
    Struct,
    TypeDecl,
    Typedef,
    UnaryOp,
    Union,
)
from util import C_TYPE_MAP, HEADER_DIR, OUTPUT_DIR, normalize_name, yaml


class HeaderMapping:
    _ksy_attribute_regex = re.compile(r"^[a-z][a-z0-9_]*$")

    def __init__(self, version: str) -> None:
        self.version = version
        self.extern_name_map: dict[str, str] = {}
        """ Stores the original symbol names mapped to the normalized names. """
        self.extern_map: dict[str, str] = {}
        """ Maps each symbol name to the type associated with it. """
        self.type_name_map: dict[str, str] = {}
        """ Stores the original type names mapped to the normalized names. """
        self.import_map: dict[str, str | None] = {}
        """ Maps each type to the corresponding ksy subtype file name. """
        self.type_folder = Path(OUTPUT_DIR, version, "types")
        """ Folder where all Kaitai Struct subtypes are saved to. """

        self._enum_cache: dict[str, dict] = {}
        """ Used for typedefs of existing enums with different bitlengths. """
        self._undefined_symbols: set[str] = set()
        """ Used to ensure structs are eventually defined. """

        if not self.type_folder.exists():
            self.type_folder.mkdir(parents=True)

        self._read_headers()

    @classmethod
    def _print_err(cls, *values: object) -> None:
        current_frame = inspect.currentframe()
        current_frame_back = current_frame.f_back if current_frame else None
        if not current_frame or not current_frame_back:
            print(f"[ERROR][{cls.__name__}]:", *values)
            return

        print(f"[ERROR][{cls.__name__}][{current_frame_back.f_code.co_name}]:", *values)

    @classmethod
    def _process_constant(cls, constant: Constant) -> int:
        if constant.type != "int" or not isinstance(constant.value, str):
            cls._print_err(
                "Failed to process Constant:\n",
                constant,
            )
            raise TypeError

        enum_value_str = str(constant.value)
        return int(enum_value_str, 16) if "x" in enum_value_str else int(enum_value_str)

    @classmethod
    def _eval_unary_op(cls, unary_op: UnaryOp) -> int:
        if not isinstance(unary_op.expr, Constant):
            cls._print_err(
                "Could not perform unary operation with unknown type of the expression:\n",
                unary_op.expr,  # type: ignore[reportUnknownArgumentType]
            )
            raise TypeError

        expr = cls._process_constant(unary_op.expr)

        if unary_op.op == "-":
            return -expr

        cls._print_err(
            "Failed to evaluate unary operation due to unknown operation.",
        )
        raise TypeError

    @classmethod
    def _eval_binary_op(cls, binary_op: BinaryOp) -> int:
        if not isinstance(binary_op.left, Constant):
            cls._print_err(
                "Could not perform binary operation with unknown type of the left operand:\n",
                binary_op.left,
            )
            raise TypeError
        if not isinstance(binary_op.right, Constant):
            cls._print_err(
                "Could not perform binary operation with unknown type of the right operand:\n",
                binary_op.right,
            )
            raise TypeError

        left_num = cls._process_constant(binary_op.left)
        right_num = cls._process_constant(binary_op.right)

        if not isinstance(binary_op.op, str):
            cls._print_err(
                f"Binary operator has unknown type '{type(binary_op.op)}'",
            )
            raise TypeError

        if binary_op.op == "+":
            return left_num + right_num
        if binary_op.op == "-":
            return left_num - right_num

        # If we got here, the operand is not supported.
        cls._print_err(
            "Unsupported operand",
            binary_op.op,
            "was called by the following:\n",
            binary_op,
        )
        raise ValueError

    def _create_type(self, type_name: str, ksy_subtype: dict) -> str:
        """Create and map a Kaitai Struct subtype to a type name.

        Returns the normalized type name.
        """
        # Check if we already fixed this type name.
        if type_name in self.type_name_map:
            normalized_name = self.type_name_map[type_name]
        else:
            # Try to convert type name to kaitai struct requirements.
            normalized_name = normalize_name(type_name)

            # Ensure the requirements are met
            if not self._ksy_attribute_regex.match(normalized_name):
                self._print_err(
                    "Failed to convert type name to Kaitai Struct requirements:",
                    f"'{type_name}' -> '{normalized_name}'",
                )
                raise ValueError

            # Store the fixed name.
            self.type_name_map[type_name] = normalized_name

        # We already created this type, this should not happen.
        if normalized_name in self.import_map:
            self._print_err(f"Attempted to save over an existing Kaitai Struct subtype '{type_name}'.")
            raise ValueError

        ksy_filename = f"{normalized_name}.ksy"

        # Write the Kaitai Struct mapping as a subtype.
        with Path(self.type_folder, ksy_filename).open("w") as f:
            yaml.dump(ksy_subtype, f)

        # Store the filename of the type for importing.
        self.import_map[normalized_name] = normalized_name

        return normalized_name

    def _map_extern(self, symbol_name: str, type_name: str) -> str:
        # Check if we already fixed the name.
        if symbol_name in self.extern_name_map:
            normalized_name = self.extern_name_map[symbol_name]
        else:
            # Try to convert symbol name to kaitai struct requirements.
            normalized_name = normalize_name(symbol_name)

            # Ensure the requirements are met.
            if not self._ksy_attribute_regex.match(normalized_name):
                self._print_err(
                    "Failed to convert symbol name to Kaitai Struct requirements:",
                    f"'{symbol_name}' -> '{normalized_name}'",
                )
                raise ValueError

            # Store the fixed name.
            self.extern_name_map[symbol_name] = normalized_name

        # Try to retrieve the kaitai subtype mapping.
        normalized_type_name = self.type_name_map.get(type_name)

        if not normalized_type_name:
            self._print_err(
                f"Failed to find mapping for type name '{type_name}'",
            )
            raise ValueError

        # Return here if we already processed this symbol prior.
        if normalized_name in self.extern_map:
            # But if the type name is different, we should throw an error.
            if self.extern_map[normalized_name] != normalized_type_name:
                self._print_err(
                    "Found different type",
                    type_name,
                    "for symbol",
                    normalized_name,
                    "this should not happen!",
                )
                raise ValueError
            return normalized_type_name

        # Map the symbol to the subtype.
        self.extern_map[normalized_name] = normalized_type_name
        return normalized_type_name

    def _read_typedef(self, typedef: Typedef) -> str:
        if isinstance(typedef.type, TypeDecl):
            return self._read_type_decl(typedef.type)

        if isinstance(typedef.type, PtrDecl):
            return self._process_pointer()

        # If we got here we aren't aware of this type.
        self._print_err("Unknown type found.")
        raise TypeError

    def _read_type_decl(
        self,
        type_decl: TypeDecl,
    ) -> str:
        if isinstance(type_decl.type, IdentifierType):
            return self._process_identifier_type(type_decl.type)
        if isinstance(type_decl.type, Enum):
            if not type_decl.type.values:
                return self.type_name_map[type_decl.type.name]
            return self._read_enum(type_decl.type)
        if isinstance(type_decl.type, Struct):
            return self._read_struct(type_decl.type)
        if isinstance(type_decl.type, Union):
            return self._read_union(type_decl.type)

        # If we got here, we aren't aware of this typedecl.
        self._print_err(
            "Failed to read type for typedecl.",
        )
        raise TypeError

    def _process_identifier_type(
        self,
        identifier_type: IdentifierType,
    ) -> str:
        type_name = " ".join(identifier_type.names)
        normalized_type_name = self.type_name_map.get(type_name)
        if not normalized_type_name:
            self._print_err(
                f"Failed to find type mapping for '{type_name}'.",
            )
            raise ValueError

        return normalized_type_name

    def _process_pointer(self) -> str:
        return "pointer"

    def _read_array(self, array: ArrayDecl, prefix: str) -> str:
        current_type = array
        array_dims = []
        while isinstance(current_type, ArrayDecl):
            array_dims.insert(0, current_type)
            current_type = current_type.type

        if isinstance(current_type, TypeDecl):
            if isinstance(current_type.type, IdentifierType):
                identifier_name = " ".join(current_type.type.names)
            elif isinstance(current_type.type, Struct):
                identifier_name = str(current_type.type.name)
            else:
                self._print_err(
                    f"Unexpected TypeDecl type '{type(current_type.type)}'",
                )
                raise TypeError
        elif isinstance(current_type, PtrDecl):
            identifier_name = "pointer"
        else:
            self._print_err(
                f"Found unknown type for array '{type(current_type)}'.",
            )
            raise TypeError

        type_name = self.type_name_map.get(identifier_name)
        if not type_name:
            self._print_err(
                f"Failed to find type mapping for '{identifier_name}'.",
            )
            raise ValueError

        array_name = prefix + "_array"
        normalized_array_name = normalize_name(array_name)
        array_subtype = {
            "doc": f"Represents an array {prefix} defined within pmdsky.",
            "meta": {
                "id": normalized_array_name,
                "endian": "le",
                "bit-endian": "le",
                "imports": self.import_map[type_name] or [],
            },
            "seq": [],
            "types": {},
        }

        for depth, array in enumerate(array_dims):
            # TODO
            pass

        return self._create_type(array_name, array_subtype)

    def _process_enumerator_value(self, enumerator: Enumerator) -> int:
        if isinstance(enumerator.value, Constant):
            return self._process_constant(enumerator.value)
        if isinstance(enumerator.value, BinaryOp):
            return self._eval_binary_op(enumerator.value)
        if isinstance(enumerator.value, UnaryOp):
            return self._eval_unary_op(enumerator.value)

        self._print_err(
            "Unknown enum value type.",
        )
        raise TypeError

    def _read_enum(self, enum: Enum, bitsize: int | None = None) -> str:
        int_bitsize = 32

        if not bitsize:
            bitsize = int_bitsize

        new_enum_name = enum.name
        if not enum.values:
            docstring = f"Holds bitsized data for the parent enum {enum.name}."
            if bitsize != int_bitsize:
                new_enum_name += f"_{bitsize}"

            if normalize_name(new_enum_name) in self._enum_cache:
                return normalize_name(new_enum_name)

            if enum.name not in self.type_name_map or self.type_name_map[enum.name] not in self._enum_cache:
                self._print_err(
                    "Enum was not defined prior.",
                )
                raise ValueError

            parent_subtype = self._enum_cache[self.type_name_map[enum.name]]
            enum_values = parent_subtype["enums"][self.type_name_map[enum.name]]
        elif isinstance(enum.values, EnumeratorList):
            docstring = f"Holds the data for the enum {enum.name}."
            enum_values = {}
            for enumerator in enum.values.enumerators:
                if not isinstance(enumerator, Enumerator):
                    self._print_err(
                        "Failed to parse enum value, unknown type.",
                    )
                    raise TypeError

                enum_value = self._process_enumerator_value(enumerator)
                enum_values[enum_value] = normalize_name(enumerator.name)
        else:
            # Enums should only have an EnumeratorList
            self._print_err(
                "Failed to parse enum values, unknown type.",
            )
            raise TypeError

        normalized_enum_name = normalize_name(new_enum_name)

        enum_subtype = {
            "doc": docstring,
            "meta": {
                "id": normalized_enum_name,
                "endian": "le",
                "bit-endian": "le",
            },
            "seq": [
                {
                    "id": normalized_enum_name,
                    "type": f"b{bitsize}",
                    "enum": normalized_enum_name,
                },
            ],
            "enums": {
                normalized_enum_name: enum_values,
            },
        }

        normalized_enum_name = self._create_type(new_enum_name, enum_subtype)
        self._enum_cache[normalized_enum_name] = enum_subtype

        return normalized_enum_name

    def _process_bitsized_decl(
        self,
        declaration: Decl,
        bitsize: int,
    ) -> dict:
        current_type = declaration.type

        if not isinstance(current_type, TypeDecl):
            self._print_err(
                "Failed to read bitsized declaration, the type is unknown.",
            )
            raise TypeError

        if not isinstance(declaration.bitsize, Constant):
            self._print_err(
                "Found a non-Constant type for bitsize",
            )
            raise TypeError

        enum_type = None
        current_type_name = self._read_type_decl(current_type)
        if isinstance(current_type.type, Enum) and current_type_name in self.type_name_map:
            normalized_type_name = self.type_name_map[current_type_name]
            if normalized_type_name not in self._enum_cache:
                self._print_err(
                    "Bitsized enum points to a non-existing enum type",
                )
                raise ValueError
            enum_type = self._read_enum(current_type.type, bitsize)

        return {
            "id": normalize_name(declaration.name),
            "type": enum_type or f"b{bitsize}",
        }

    def _read_struct(self, struct: Struct) -> str:  # noqa: C901, PLR0912
        decls = struct.decls
        if not decls:
            if struct.name not in self.type_name_map:
                self._undefined_symbols.add(struct.name)
                return struct.name

            return self.type_name_map[struct.name]

        if not isinstance(decls, list):
            self._print_err(
                "Failed to read struct, unknown type within the declarations.",
            )
            raise TypeError

        struct_subtype = {
            "doc": f"Represents a struct {struct.name} defined within pmdsky.",
            "meta": {
                "id": normalize_name(struct.name),
                "endian": "le",
                "bit-endian": "le",
                "imports": [],
            },
            "seq": [],
        }

        # We need to be able to skip a range of decls.
        for declaration in decls:
            if not isinstance(declaration, Decl):
                self._print_err(
                    "Failed to read declaration, the type is not known.",
                )
                raise TypeError

            if declaration.bitsize and not isinstance(declaration.bitsize, Constant):
                self._print_err(
                    "Failed to read bitsize, the type was not a Constant.",
                )
                raise TypeError

            bitsize = None
            if declaration.bitsize:
                bitsize = self._process_constant(declaration.bitsize)

            if bitsize:
                entry = self._process_bitsized_decl(declaration, bitsize)
                struct_subtype["seq"].append(entry)
                continue

            entry = {
                "id": normalize_name(declaration.name),
            }

            declaration_type = declaration.type

            if isinstance(declaration_type, TypeDecl):
                type_name = self._read_type_decl(declaration_type)
            elif isinstance(declaration_type, ArrayDecl):
                type_name = self._read_array(declaration_type, declaration.name)
            elif isinstance(declaration_type, Enum):
                type_name = self._read_enum(declaration_type, bitsize)
            elif isinstance(declaration_type, PtrDecl):
                type_name = "pointer"
            else:
                self._print_err(
                    "Failed to read unknown type declaration on struct.",
                )
                raise TypeError

            import_name = self.import_map[type_name]
            if import_name and import_name not in struct_subtype["meta"]["imports"]:
                struct_subtype["meta"]["imports"].append(import_name)

            entry["type"] = type_name
            struct_subtype["seq"].append(entry)

        if len(struct_subtype["seq"]) != len(decls):
            self._print_err(
                "The size of the struct subtype does not match the C struct declarations.",
            )
            raise ValueError

        self._undefined_symbols.discard(struct.name)
        return self._create_type(struct.name, struct_subtype)

    def _read_union(self, union: Union) -> str:  # noqa: C901, PLR0912
        decls = union.decls
        if not decls:
            if union.name not in self.type_name_map:
                self._undefined_symbols.add(union.name)
                return union.name

            return self.type_name_map[union.name]

        if not isinstance(decls, list):
            self._print_err(
                "Failed to read union, unknown type within the declarations.",
            )
            raise TypeError

        union_subtype = {
            "doc": f"Represents a union {union.name} defined within pmdsky.",
            "meta": {
                "id": normalize_name(union.name),
                "endian": "le",
                "bit-endian": "le",
                "imports": [],
            },
            "seq": [],
        }

        # We need to be able to skip a range of decls.
        for declaration in decls:
            if not isinstance(declaration, Decl):
                self._print_err(
                    "Failed to read declaration, the type is not known.",
                )
                raise TypeError

            if declaration.bitsize and not isinstance(declaration.bitsize, Constant):
                self._print_err(
                    "Failed to read bitsize, the type was not a Constant.",
                )
                raise TypeError

            bitsize = None
            if declaration.bitsize:
                bitsize = self._process_constant(declaration.bitsize)

            if bitsize:
                entry = self._process_bitsized_decl(declaration, bitsize)
                union_subtype["seq"].append(entry)
                continue

            entry = {
                "id": normalize_name(declaration.name),
            }

            declaration_type = declaration.type

            if isinstance(declaration_type, TypeDecl):
                type_name = self._read_type_decl(declaration_type)
            elif isinstance(declaration_type, ArrayDecl):
                type_name = self._read_array(declaration_type, f"{union.name}_{declaration.name}")
            elif isinstance(declaration_type, Enum):
                type_name = self._read_enum(declaration_type, bitsize)
            elif isinstance(declaration_type, PtrDecl):
                type_name = "pointer"
            else:
                self._print_err(
                    "Failed to read unknown type declaration on union.",
                )
                raise TypeError

            import_name = self.import_map[type_name]
            if import_name and import_name not in union_subtype["meta"]["imports"]:
                union_subtype["meta"]["imports"].append(import_name)

            entry["type"] = type_name
            union_subtype["seq"].append(entry)

        if len(union_subtype["seq"]) != len(decls):
            self._print_err(
                "The size of the union subtype does not match the C union declarations.",
            )
            raise ValueError

        self._undefined_symbols.discard(union.name)
        return self._create_type(union.name, union_subtype)

    def _read_headers(self) -> None:  # noqa: C901, PLR0912 Breaking up this function doesn't make sense.
        # Add the predefined c types to the type map.
        for type_name in C_TYPE_MAP:
            self.type_name_map[type_name] = C_TYPE_MAP[type_name]
            self.import_map[C_TYPE_MAP[type_name]] = None

        # Pointers can be predefined as well.
        self._create_type(
            "pointer",
            {
                "doc": "Represents a memory address stored within the binary.",
                "meta": {
                    "id": "pointer",
                    "endian": "le",
                    "bit-endian": "le",
                },
                "seq": [
                    {
                        "id": "mem_address",
                        "type": "u4",
                    },
                ],
            },
        )

        ast = parse_file(
            Path(HEADER_DIR, f"pmdsky_{self.version.lower()}.h"),
            use_cpp=True,
            cpp_path="clang",  # Clang parses pmdsky-debug better.
            cpp_args=["-E", r"-m32", r"-fshort-wchar", r"-mno-ms-bitfields"],  # type: ignore[reportArgumentType]
        )

        for entry in ast:
            print(entry)
            if isinstance(entry, Typedef):
                self._read_typedef(entry)
            elif isinstance(entry, Decl):
                if entry.bitsize is not None:
                    self._print_err(
                        "Bitsizes need to be handled.",
                    )
                    raise ValueError

                if isinstance(entry.type, FuncDecl):
                    # Functions are processed elsewhere.
                    continue

                if isinstance(entry.type, ArrayDecl):
                    type_name = self._read_array(entry.type, entry.name)
                elif isinstance(entry.type, Enum):
                    type_name = self._read_enum(entry.type)
                elif isinstance(entry.type, PtrDecl):
                    type_name = self._process_pointer()
                elif isinstance(entry.type, Struct):
                    type_name = self._read_struct(entry.type)
                elif isinstance(entry.type, TypeDecl):
                    type_name = self._read_type_decl(entry.type)
                elif isinstance(entry.type, Union):
                    type_name = self._read_union(entry.type)
                else:
                    self._print_err(
                        f"Unknown declaration type '{type(entry.type)}'",
                    )
                    raise TypeError

                if "".join(entry.storage) == "extern":
                    self._map_extern(entry.name, type_name)
            elif isinstance(entry, (StaticAssert, Pragma)):
                # These are not useful.
                continue
            else:
                self._print_err(
                    f"The following entry was not processed:\n{entry}",
                )
                raise TypeError

        if len(self._undefined_symbols) > 0:
            self._print_err(
                "The following structs and/or unions were never defined during parsing:\n",
                "\n".join(self._undefined_symbols),
            )
            raise RuntimeError
