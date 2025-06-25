doc: Holds the data for the enum secondary_terrain_type.
meta:
  id: secondary_terrain_type
  endian: le
  bit-endian: le
seq:
- id: secondary_terrain_type_value
  type: b32
  enum: secondary_terrain_type_enum
enums:
  secondary_terrain_type_enum:
    0: secondary_terrain_water
    1: secondary_terrain_lava
    2: secondary_terrain_chasm
