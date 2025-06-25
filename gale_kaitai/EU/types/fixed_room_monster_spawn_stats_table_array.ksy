doc: Represents an array FIXED_ROOM_MONSTER_SPAWN_STATS_TABLE defined within 
  pmdsky.
meta:
  id: fixed_room_monster_spawn_stats_table_array
  endian: le
  bit-endian: le
  imports:
  - fixed_room_monster_spawn_stats_entry
seq:
- id: entries
  type: fixed_room_monster_spawn_stats_table_array_dim_0
types:
  fixed_room_monster_spawn_stats_table_array_dim_0:
    seq:
    - id: entries
      type: fixed_room_monster_spawn_stats_entry
      repeat: expr
      repeat-expr: 99
