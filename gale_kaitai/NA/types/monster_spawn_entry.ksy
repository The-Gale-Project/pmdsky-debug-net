doc: Represents a struct or union monster_spawn_entry defined within 
  pmdsky-debug.
meta:
  id: monster_spawn_entry
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: level_mult_512
  type: u2
- id: incremental_spawn_weight
  type: u2
- id: incremental_spawn_weight_monster_house
  type: u2
- id: id
  type: monster_id_16
