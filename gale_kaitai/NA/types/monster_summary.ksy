doc: Represents a struct or union monster_summary defined within pmdsky-debug.
meta:
  id: monster_summary
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
  - monster_summary_monster_name_array
  - monster_summary_types_array
  - monster_summary_abilities_array
  - dungeon_id_8
  - item
  - monster_summary_offensive_stats_array
  - monster_summary_defensive_stats_array
  - monster_summary_iq_skill_flags_array
  - tactic_id_8
  - monster_summary_active_statuses_array
seq:
- id: id
  type: monster_id_16
- id: monster_name
  type: monster_summary_monster_name_array
- id: field_0xc
  type: u1
- id: field_0xd
  type: u1
- id: field_0xe
  type: u1
- id: field_0xf
  type: u1
- id: field_0x10
  type: u1
- id: field_0x11
  type: u1
- id: field_0x12
  type: u1
- id: field_0x13
  type: u1
- id: field_0x14
  type: u1
- id: field_0x15
  type: u1
- id: types
  type: monster_summary_types_array
- id: abilities
  type: monster_summary_abilities_array
- id: joined_at
  type: dungeon_id_8
- id: joined_at_floor
  type: u1
- id: held_item
  type: item
- id: field_0x22
  type: u1
- id: field_0x23
  type: u1
- id: hp
  type: s4
- id: max_hp
  type: s4
- id: level
  type: u4
- id: exp
  type: s4
- id: offensive_stats
  type: monster_summary_offensive_stats_array
- id: defensive_stats
  type: monster_summary_defensive_stats_array
- id: is_team_leader
  type: u1
- id: attack_boost
  type: u1
- id: special_attack_boost
  type: u1
- id: defense_boost
  type: u1
- id: special_defense_boost
  type: u1
- id: field_0x3d
  type: u1
- id: iq
  type: s2
- id: field_0x40
  type: u1
- id: field_0x41
  type: u1
- id: level_at_first_evo
  type: u1
- id: level_at_second_evo
  type: u1
- id: evo_status
  type: u1
- id: inflicted_with_gastro_acid
  type: u1
- id: field_0x46
  type: u1
- id: field_0x47
  type: u1
- id: iq_skill_flags
  type: monster_summary_iq_skill_flags_array
- id: tactic
  type: tactic_id_8
- id: field_0x55
  type: u1
- id: field_0x56
  type: u1
- id: field_0x57
  type: u1
- id: active_statuses
  type: monster_summary_active_statuses_array
- id: padding_0x76
  type: u2
