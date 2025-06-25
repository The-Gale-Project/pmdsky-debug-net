doc: Represents an array dungeon_unknown_matrix_0x1212C defined within pmdsky.
meta:
  id: dungeon_unknown_matrix_0x1212c_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_unknown_matrix_0x1212c_array_dim_1
types:
  dungeon_unknown_matrix_0x1212c_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 3
  dungeon_unknown_matrix_0x1212c_array_dim_1:
    seq:
    - id: entries
      type: dungeon_unknown_matrix_0x1212c_array_dim_0
      repeat: expr
      repeat-expr: 9
