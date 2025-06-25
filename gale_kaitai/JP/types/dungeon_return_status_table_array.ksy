doc: Represents an array DUNGEON_RETURN_STATUS_TABLE defined within pmdsky.
meta:
  id: dungeon_return_status_table_array
  endian: le
  bit-endian: le
  imports:
  - dungeon_return_status
seq:
- id: entries
  type: dungeon_return_status_table_array_dim_0
types:
  dungeon_return_status_table_array_dim_0:
    seq:
    - id: entries
      type: dungeon_return_status
      repeat: expr
      repeat-expr: 91
