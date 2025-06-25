doc: Holds bitsized data for the parent enum terrain_type.
meta:
  id: terrain_type_2
  endian: le
  bit-endian: le
seq:
- id: terrain_type_2_value
  type: b2
  enum: terrain_type_2_enum
enums:
  terrain_type_2_enum:
    0: terrain_wall
    1: terrain_normal
    2: terrain_secondary
    3: terrain_chasm
