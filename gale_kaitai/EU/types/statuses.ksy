doc: Represents a struct or union statuses defined within pmdsky-debug.
meta:
  id: statuses
  endian: le
  bit-endian: le
  imports:
  - statuses_original_types_array
  - monster_behavior_8
  - status_sleep_id_8
  - status_burn_id_8
  - status_frozen_id_8
  - status_cringe_id_8
  - status_two_turn_id_8
  - status_reflect_id_8
  - status_curse_id_8
  - status_leech_seed_id_8
  - status_sure_shot_id_8
  - status_long_toss_id_8
  - status_invisible_id_8
  - status_blinker_id_8
  - statuses_speed_up_counters_array
  - statuses_speed_down_counters_array
seq:
- id: roost
  type: u1
- id: original_types
  type: statuses_original_types_array
- id: bide_move_id
  type: u1
- id: field_0x4
  type: u1
- id: field_0x5
  type: u1
- id: field_0x6
  type: u1
- id: unique_id
  type: u4
- id: wrap_pair_unique_id
  type: u4
- id: bide_damage_tally
  type: u4
- id: monster_behavior
  type: monster_behavior_8
- id: sleep
  type: status_sleep_id_8
- id: sleep_turns
  type: u1
- id: burn
  type: status_burn_id_8
- id: burn_turns
  type: u1
- id: burn_damage_countdown
  type: u1
- id: badly_poisoned_damage_count
  type: u1
- id: field_0x1a
  type: u1
- id: freeze
  type: status_frozen_id_8
- id: field_0x1c
  type: u1
- id: field_0x1d
  type: u1
- id: field_0x1e
  type: u1
- id: constriction_animation
  type: u4
- id: freeze_turns
  type: u1
- id: freeze_damage_countdown
  type: u1
- id: field_0x25
  type: u1
- id: field_0x26
  type: u1
- id: cringe
  type: status_cringe_id_8
- id: cringe_turns
  type: u1
- id: bide
  type: status_two_turn_id_8
- id: bide_turns
  type: u1
- id: bide_move_slot
  type: u1
- id: reflect
  type: status_reflect_id_8
- id: reflect_turns
  type: u1
- id: reflect_damage_countdown
  type: u1
- id: curse
  type: status_curse_id_8
- id: curse_applier_non_team_member_flag
  type: u1
- id: unk_decoy_tracker
  type: u1
- id: curse_turns
  type: u1
- id: curse_damage_countdown
  type: u1
- id: field_0x34
  type: u1
- id: field_0x35
  type: u1
- id: field_0x36
  type: u1
- id: leech_seed
  type: status_leech_seed_id_8
- id: field_0x38
  type: u1
- id: field_0x39
  type: u1
- id: field_0x3a
  type: u1
- id: statuses_applier_id
  type: u4
- id: leech_seed_source_monster_index
  type: u1
- id: leech_seed_turns
  type: u1
- id: leech_seed_damage_countdown
  type: u1
- id: field_0x42
  type: u1
- id: sure_shot
  type: status_sure_shot_id_8
- id: sure_shot_turns
  type: u1
- id: long_toss
  type: status_long_toss_id_8
- id: invisible
  type: status_invisible_id_8
- id: invisible_turns
  type: u1
- id: blinded
  type: status_blinker_id_8
- id: blinded_turns
  type: u1
- id: muzzled
  type: u1
- id: muzzled_turns
  type: u1
- id: miracle_eye
  type: u1
- id: miracle_eye_turns
  type: u1
- id: magnet_rise
  type: u1
- id: magnet_rise_turns
  type: u1
- id: power_ears
  type: u1
- id: scanning
  type: u1
- id: stair_spotter
  type: u1
- id: pickup_flag
  type: u1
- id: grudge
  type: u1
- id: exposed
  type: u1
- id: type_changed
  type: u1
- id: boss_flag
  type: u1
- id: unk_sped_up_tracker
  type: u1
- id: field_0x59
  type: u1
- id: in_action
  type: u1
- id: terrified
  type: u1
- id: terrified_turns
  type: u1
- id: perish_song_turns
  type: u1
- id: no_slip_cap_counter
  type: u1
- id: exp_yield
  type: u1
- id: use_held_item
  type: u1
- id: field_0x61
  type: u1
- id: two_turn_move_invincible
  type: u1
- id: decoy_ai_tracker
  type: u1
- id: field_0x64
  type: u1
- id: field_0x65
  type: u1
- id: field_0x66
  type: u1
- id: speed_stage
  type: s4
- id: speed_up_counters
  type: statuses_speed_up_counters_array
- id: speed_down_counters
  type: statuses_speed_down_counters_array
- id: stockpile_stage
  type: u1
