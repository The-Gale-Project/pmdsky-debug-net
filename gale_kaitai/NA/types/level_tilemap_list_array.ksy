doc: Represents an array LEVEL_TILEMAP_LIST defined within pmdsky.
meta:
  id: level_tilemap_list_array
  endian: le
  bit-endian: le
  imports:
  - level_tilemap_list_entry
seq:
- id: entries
  type: level_tilemap_list_array_dim_0
types:
  level_tilemap_list_array_dim_0:
    seq:
    - id: entries
      type: level_tilemap_list_entry
      repeat: expr
      repeat-expr: 81
