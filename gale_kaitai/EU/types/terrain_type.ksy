doc: Holds the data for the enum terrain_type.
meta:
  id: terrain_type
  endian: le
  bit-endian: le
seq:
- id: terrain_type_value
  type: b32
  enum: terrain_type_enum
enums:
  terrain_type_enum:
    0: terrain_wall
    1: terrain_normal
    2: terrain_secondary
    3: terrain_chasm
