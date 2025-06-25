doc: Holds the data for the enum display_name_type.
meta:
  id: display_name_type
  endian: le
  bit-endian: le
seq:
- id: display_name_type_value
  type: b32
  enum: display_name_type_enum
enums:
  display_name_type_enum:
    0: display_name_normal
    1: display_name_unknown
    2: display_name_decoy
