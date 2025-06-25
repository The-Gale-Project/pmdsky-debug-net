doc: Represents a struct or union ground_monster defined within pmdsky-debug.
meta:
  id: ground_monster
  endian: le
  bit-endian: le
  imports:
  - dungeon_id_8
  - monster_id_16
  - ground_monster_offensive_stats_array
  - ground_monster_defensive_stats_array
  - ground_monster_iq_skill_flags_array
  - tactic_id_8
  - ground_monster_moves_array
  - ground_monster_name_array
seq:
- id: is_valid
  type: u1
- id: level
  type: s1
- id: joined_at
  type: dungeon_id_8
- id: joined_at_floor
  type: u1
- id: id
  type: monster_id_16
- id: level_at_first_evo
  type: s1
- id: level_at_second_evo
  type: s1
- id: iq
  type: u2
- id: max_hp
  type: u2
- id: offensive_stats
  type: ground_monster_offensive_stats_array
- id: defensive_stats
  type: ground_monster_defensive_stats_array
- id: exp
  type: s4
- id: iq_skill_flags
  type: ground_monster_iq_skill_flags_array
- id: tactic
  type: tactic_id_8
- id: field_0x21
  type: u1
- id: moves
  type: ground_monster_moves_array
- id: name
  type: ground_monster_name_array
