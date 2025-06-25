doc: Represents an array MISSION_DUNGEON_UNLOCK_TABLE defined within pmdsky.
meta:
  id: mission_dungeon_unlock_table_array
  endian: le
  bit-endian: le
  imports:
  - dungeon_unlock_entry
seq:
- id: entries
  type: mission_dungeon_unlock_table_array_dim_0
types:
  mission_dungeon_unlock_table_array_dim_0:
    seq:
    - id: entries
      type: dungeon_unlock_entry
      repeat: expr
      repeat-expr: 3
