doc: Represents an array MAP_COLOR_TABLE defined within pmdsky.
meta:
  id: map_color_table_array
  endian: le
  bit-endian: le
  imports:
  - rgba
seq:
- id: entries
  type: map_color_table_array_dim_0
types:
  map_color_table_array_dim_0:
    seq:
    - id: entries
      type: rgba
      repeat: expr
      repeat-expr: 9
