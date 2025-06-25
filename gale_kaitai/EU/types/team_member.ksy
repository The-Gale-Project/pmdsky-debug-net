doc: Represents a struct or union team_member defined within pmdsky-debug.
meta:
  id: team_member
  endian: le
  bit-endian: le
  imports:
  - dungeon_id_8
  - monster_id_16
  - team_member_offensive_stats_array
  - team_member_defensive_stats_array
  - team_member_moves_array
  - item
  - team_member_iq_skill_flags_array
  - tactic_id_8
  - type_id_8
  - team_member_name_array
seq:
- id: f_is_valid
  type: b1
- id: flags_unk1
  type: b7
- id: is_leader
  type: u1
- id: level
  type: u1
- id: joined_at
  type: dungeon_id_8
- id: joined_at_floor
  type: u1
- id: field_0x5
  type: u1
- id: iq
  type: u2
- id: member_index
  type: s2
- id: team_index
  type: s2
- id: id
  type: monster_id_16
- id: current_hp
  type: u2
- id: max_hp
  type: u2
- id: offensive_stats
  type: team_member_offensive_stats_array
- id: defensive_stats
  type: team_member_defensive_stats_array
- id: field_0x16
  type: u1
- id: field_0x17
  type: u1
- id: exp
  type: s4
- id: moves
  type: team_member_moves_array
- id: field_0x3c
  type: u1
- id: field_0x3d
  type: u1
- id: held_item
  type: item
- id: belly
  type: s2
- id: belly_thousandths
  type: s2
- id: max_belly
  type: s2
- id: max_belly_thousandths
  type: s2
- id: iq_skill_flags
  type: team_member_iq_skill_flags_array
- id: tactic
  type: tactic_id_8
- id: field_0x59
  type: u1
- id: hidden_power_base_power
  type: s2
- id: hidden_power_type
  type: type_id_8
- id: field_0x5d
  type: u1
- id: name
  type: team_member_name_array
