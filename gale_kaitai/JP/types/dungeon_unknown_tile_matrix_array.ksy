doc: Represents an array dungeon_unknown_tile_matrix defined within pmdsky.
meta:
  id: dungeon_unknown_tile_matrix_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_unknown_tile_matrix_array_dim_1
types:
  dungeon_unknown_tile_matrix_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 34
  dungeon_unknown_tile_matrix_array_dim_1:
    seq:
    - id: entries
      type: dungeon_unknown_tile_matrix_array_dim_0
      repeat: expr
      repeat-expr: 9
