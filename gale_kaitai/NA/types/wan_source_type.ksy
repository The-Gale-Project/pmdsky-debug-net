doc: Holds the data for the enum wan_source_type.
meta:
  id: wan_source_type
  endian: le
  bit-endian: le
seq:
- id: wan_source_type_value
  type: b32
  enum: wan_source_type_enum
enums:
  wan_source_type_enum:
    0: wan_source_null
    1: wan_source_file
    2: wan_source_pack
