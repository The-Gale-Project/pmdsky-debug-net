doc: Represents an array DUNGEON_SWAP_ID_TABLE defined within pmdsky.
meta:
  id: dungeon_swap_id_table_array
  endian: le
  bit-endian: le
  imports:
  - dungeon_id_8
seq:
- id: entries
  type: dungeon_swap_id_table_array_dim_0
types:
  dungeon_swap_id_table_array_dim_0:
    seq:
    - id: entries
      type: dungeon_id_8
      repeat: expr
      repeat-expr: 212
