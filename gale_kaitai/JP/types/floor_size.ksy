doc: Holds the data for the enum floor_size.
meta:
  id: floor_size
  endian: le
  bit-endian: le
seq:
- id: floor_size_value
  type: b32
  enum: floor_size_enum
enums:
  floor_size_enum:
    0: floor_size_large
    1: floor_size_small
    2: floor_size_medium
