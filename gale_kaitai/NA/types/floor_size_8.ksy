doc: Holds bitsized data for the parent enum floor_size.
meta:
  id: floor_size_8
  endian: le
  bit-endian: le
seq:
- id: floor_size_8_value
  type: b8
  enum: floor_size_8_enum
enums:
  floor_size_8_enum:
    0: floor_size_large
    1: floor_size_small
    2: floor_size_medium
