doc: Represents an array dungeon_color_table defined within pmdsky.
meta:
  id: dungeon_color_table_array
  endian: le
  bit-endian: le
  imports:
  - rgba
seq:
- id: entries
  type: dungeon_color_table_array_dim_0
types:
  dungeon_color_table_array_dim_0:
    seq:
    - id: entries
      type: rgba
      repeat: expr
      repeat-expr: 256
