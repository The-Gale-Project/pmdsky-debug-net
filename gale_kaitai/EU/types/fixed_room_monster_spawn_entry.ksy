doc: Represents a struct or union fixed_room_monster_spawn_entry defined within 
  pmdsky-debug.
meta:
  id: fixed_room_monster_spawn_entry
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
  - monster_behavior_8
seq:
- id: id
  type: monster_id_16
- id: stat_table_idx
  type: u1
- id: behavior
  type: monster_behavior_8
