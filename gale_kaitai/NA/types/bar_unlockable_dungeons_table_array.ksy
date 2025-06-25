doc: Represents an array BAR_UNLOCKABLE_DUNGEONS_TABLE defined within pmdsky.
meta:
  id: bar_unlockable_dungeons_table_array
  endian: le
  bit-endian: le
  imports:
  - dungeon_id_16
seq:
- id: entries
  type: bar_unlockable_dungeons_table_array_dim_0
types:
  bar_unlockable_dungeons_table_array_dim_0:
    seq:
    - id: entries
      type: dungeon_id_16
      repeat: expr
      repeat-expr: 6
