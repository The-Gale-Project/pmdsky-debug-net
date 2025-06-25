doc: Represents an array DUNGEON_DATA_LIST defined within pmdsky.
meta:
  id: dungeon_data_list_array
  endian: le
  bit-endian: le
  imports:
  - dungeon_data_list_entry
seq:
- id: entries
  type: dungeon_data_list_array_dim_0
types:
  dungeon_data_list_array_dim_0:
    seq:
    - id: entries
      type: dungeon_data_list_entry
      repeat: expr
      repeat-expr: 180
