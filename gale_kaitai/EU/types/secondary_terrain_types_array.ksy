doc: Represents an array SECONDARY_TERRAIN_TYPES defined within pmdsky.
meta:
  id: secondary_terrain_types_array
  endian: le
  bit-endian: le
  imports:
  - secondary_terrain_type_8
seq:
- id: entries
  type: secondary_terrain_types_array_dim_0
types:
  secondary_terrain_types_array_dim_0:
    seq:
    - id: entries
      type: secondary_terrain_type_8
      repeat: expr
      repeat-expr: 200
