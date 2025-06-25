doc: Holds the data for the enum floor_type.
meta:
  id: floor_type
  endian: le
  bit-endian: le
seq:
- id: floor_type_value
  type: b32
  enum: floor_type_enum
enums:
  floor_type_enum:
    0: floor_type_normal
    1: floor_type_fixed
    2: floor_type_rescue
