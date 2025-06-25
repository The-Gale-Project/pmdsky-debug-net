doc: Holds the data for the enum box_type.
meta:
  id: box_type
  endian: le
  bit-endian: le
seq:
- id: box_type_value
  type: b32
  enum: box_type_enum
enums:
  box_type_enum:
    254: box_type_normal
    251: box_type_invisible
