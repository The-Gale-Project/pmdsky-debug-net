doc: Represents a struct or union monster defined within pmdsky-debug.
meta:
  id: monster
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
  - shopkeeper_mode_8
  - monster_offensive_stats_array
  - monster_defensive_stats_array
  - monster_stat_modifiers
  - type_id_8
  - dungeon_id_8
  - action_data
  - monster_types_array
  - monster_abilities_array
  - item
  - item_id_16
  - position
  - ai_objective_8
  - pointer
  - monster_iq_skill_menu_flags_array
  - monster_iq_skill_flags_array
  - tactic_id_8
  - statuses
  - monster_moves_array
  - direction_id_8
  - status_icon_flags
  - monster_exclusive_item_offense_boosts_array
  - monster_exclusive_item_defense_boosts_array
  - monster_exclusive_item_effect_flags_array
seq:
- id: f_ai_unk
  type: b1
- id: f_ai_skip_turn
  type: b1
- id: flags_unk2
  type: b3
- id: f_swapping_places
  type: b1
- id: flags_unk6
  type: b3
- id: f_walking
  type: b1
- id: flags_unk10
  type: b5
- id: f_swapping_places_petrified_ally
  type: b1
- id: id
  type: monster_id_16
- id: apparent_id
  type: monster_id_16
- id: is_not_team_member
  type: u1
- id: is_team_leader
  type: u1
- id: is_ally
  type: u1
- id: shopkeeper
  type: shopkeeper_mode_8
- id: level
  type: u1
- id: field_0xb
  type: u1
- id: team_index
  type: s2
- id: iq
  type: s2
- id: hp
  type: s2
- id: max_hp_stat
  type: s2
- id: field_0x14
  type: u1
- id: field_0x15
  type: u1
- id: max_hp_boost
  type: s2
- id: field_0x18
  type: u1
- id: field_0x19
  type: u1
- id: offensive_stats
  type: monster_offensive_stats_array
- id: defensive_stats
  type: monster_defensive_stats_array
- id: field_0x1e
  type: u1
- id: field_0x1f
  type: u1
- id: exp
  type: s4
- id: stat_modifiers
  type: monster_stat_modifiers
- id: hidden_power_base_power
  type: s2
- id: hidden_power_type
  type: type_id_8
- id: field_0x47
  type: u1
- id: joined_at
  type: dungeon_id_8
- id: joined_at_floor
  type: u1
- id: action
  type: action_data
- id: types
  type: monster_types_array
- id: abilities
  type: monster_abilities_array
- id: held_item
  type: item
- id: previous_held_item_id
  type: item_id_16
- id: prev_pos
  type: position
- id: prev_pos2
  type: position
- id: prev_pos3
  type: position
- id: prev_pos4
  type: position
- id: field_0x7a
  type: u1
- id: field_0x7b
  type: u1
- id: ai_objective
  type: ai_objective_8
- id: ai_not_next_to_target
  type: u1
- id: ai_targeting_enemy
  type: u1
- id: ai_turning_around
  type: u1
- id: ai_target_spawn_genid
  type: u2
- id: field_0x82
  type: u1
- id: field_0x83
  type: u1
- id: ai_target
  type: pointer
- id: field_0x88
  type: u1
- id: field_0x89
  type: u1
- id: field_0x8a
  type: u1
- id: field_0x8b
  type: u1
- id: ai_target_pos
  type: position
- id: iq_skill_menu_flags
  type: monster_iq_skill_menu_flags_array
- id: iq_skill_flags
  type: monster_iq_skill_flags_array
- id: tactic
  type: tactic_id_8
- id: statuses
  type: statuses
- id: field_0x11f
  type: u1
- id: random_movement
  type: s4
- id: moves
  type: monster_moves_array
- id: struggle_move_flags
  type: u1
- id: field_0x145
  type: u1
- id: belly
  type: s2
- id: belly_thousandths
  type: s2
- id: max_belly
  type: s2
- id: max_belly_thousandths
  type: s2
- id: ai_ally_skip
  type: u1
- id: ai_next_to_target
  type: u1
- id: famished
  type: u1
- id: waiting
  type: u1
- id: already_acted
  type: u1
- id: should_evolve
  type: u1
- id: using_charged_move
  type: u1
- id: hit_grudge_monster
  type: u1
- id: field_0x156
  type: u1
- id: field_0x157
  type: u1
- id: state_flags
  type: u2
- id: prev_state_flags
  type: u2
- id: apply_flash_fire_boost
  type: u1
- id: rollout_hit_counter
  type: u1
- id: memento_warp_flag
  type: u1
- id: overheat_special_attack_drop_flag
  type: u1
- id: display_shadow
  type: u1
- id: cannot_give_items
  type: u1
- id: field_0x162
  type: u1
- id: field_0x163
  type: u1
- id: took_damage_flag
  type: u1
- id: field_0x165
  type: u1
- id: practice_swinger_flag
  type: u1
- id: anger_point_flag
  type: u1
- id: field_0x168
  type: u1
- id: field_0x169
  type: u1
- id: force_turn
  type: direction_id_8
- id: field_0x16b
  type: u1
- id: field_0x16c
  type: u1
- id: field_0x16d
  type: u1
- id: field_0x16e
  type: u1
- id: field_0x16f
  type: u1
- id: uturn_hide_monster_flag
  type: u1
- id: field_0x171
  type: u1
- id: pitfall_trap_flag_0x172
  type: u1
- id: field_0x173
  type: u1
- id: pitfall_trap_flag_0x174
  type: u1
- id: field_0x175
  type: u1
- id: field_0x176
  type: u1
- id: sleep_talk_direction
  type: direction_id_8
- id: snore_direction
  type: direction_id_8
- id: field_0x179
  type: u1
- id: field_0x17a
  type: u1
- id: field_0x17b
  type: u1
- id: turns_since_last_warp_scarf
  type: u1
- id: field_0x17d
  type: u1
- id: target_pos
  type: position
- id: pixel_pos
  type: position
- id: field_0x186
  type: u1
- id: field_0x187
  type: u1
- id: field_0x188
  type: u1
- id: field_0x189
  type: u1
- id: field_0x18a
  type: u1
- id: field_0x18b
  type: u1
- id: exclusive_item_trigger_bitflags
  type: u4
- id: field_0x190
  type: s2
- id: contact_ability_trigger_bitflags
  type: u2
- id: field_0x194
  type: u1
- id: field_0x195
  type: u1
- id: field_0x196
  type: u1
- id: field_0x197
  type: u1
- id: field_0x198
  type: u1
- id: field_0x199
  type: u1
- id: field_0x19a
  type: u1
- id: field_0x19b
  type: u1
- id: pos
  type: position
- id: field_0x1a0
  type: u1
- id: field_0x1a1
  type: u1
- id: field_0x1a2
  type: u1
- id: field_0x1a3
  type: u1
- id: field_0x1a4
  type: u1
- id: field_0x1a5
  type: u1
- id: field_0x1a6
  type: u1
- id: field_0x1a7
  type: u1
- id: field_0x1a8
  type: u1
- id: field_0x1a9
  type: u1
- id: field_0x1aa
  type: u1
- id: field_0x1ab
  type: u1
- id: field_0x1ac
  type: u1
- id: field_0x1ad
  type: u1
- id: field_0x1ae
  type: u1
- id: field_0x1af
  type: u1
- id: field_0x1b0
  type: u1
- id: field_0x1b1
  type: u1
- id: field_0x1b2
  type: u1
- id: field_0x1b3
  type: u1
- id: walk_anim_frames_left
  type: u2
- id: field_0x1b6
  type: u1
- id: field_0x1b7
  type: u1
- id: field_0x1b8
  type: u1
- id: field_0x1b9
  type: u1
- id: field_0x1ba
  type: u1
- id: field_0x1bb
  type: u1
- id: field_0x1bc
  type: u1
- id: field_0x1bd
  type: u1
- id: field_0x1be
  type: u1
- id: field_0x1bf
  type: u1
- id: field_0x1c0
  type: u1
- id: field_0x1c1
  type: u1
- id: field_0x1c2
  type: u1
- id: field_0x1c3
  type: u1
- id: field_0x1c4
  type: u1
- id: field_0x1c5
  type: u1
- id: field_0x1c6
  type: u1
- id: field_0x1c7
  type: u1
- id: field_0x1c8
  type: u1
- id: field_0x1c9
  type: u1
- id: field_0x1ca
  type: u1
- id: field_0x1cb
  type: u1
- id: field_0x1cc
  type: u1
- id: field_0x1cd
  type: u1
- id: field_0x1ce
  type: u1
- id: field_0x1cf
  type: u1
- id: field_0x1d0
  type: u1
- id: field_0x1d1
  type: u1
- id: field_0x1d2
  type: u1
- id: field_0x1d3
  type: u1
- id: field_0x1d4
  type: u1
- id: field_0x1d5
  type: u1
- id: field_0x1d6
  type: u1
- id: field_0x1d7
  type: u1
- id: field_0x1d8
  type: u1
- id: field_0x1d9
  type: u1
- id: field_0x1da
  type: u1
- id: field_0x1db
  type: u1
- id: field_0x1dc
  type: u1
- id: field_0x1dd
  type: u1
- id: field_0x1de
  type: u1
- id: field_0x1df
  type: u1
- id: field_0x1e0
  type: u1
- id: field_0x1e1
  type: u1
- id: field_0x1e2
  type: u1
- id: field_0x1e3
  type: u1
- id: field_0x1e4
  type: u1
- id: field_0x1e5
  type: u1
- id: field_0x1e6
  type: u1
- id: field_0x1e7
  type: u1
- id: field_0x1e8
  type: u1
- id: field_0x1e9
  type: u1
- id: field_0x1ea
  type: u1
- id: field_0x1eb
  type: u1
- id: field_0x1ec
  type: u1
- id: field_0x1ed
  type: u1
- id: field_0x1ee
  type: u1
- id: field_0x1ef
  type: u1
- id: field_0x1f0
  type: u1
- id: field_0x1f1
  type: u1
- id: field_0x1f2
  type: u1
- id: field_0x1f3
  type: u1
- id: field_0x1f4
  type: u1
- id: field_0x1f5
  type: u1
- id: field_0x1f6
  type: u1
- id: field_0x1f7
  type: u1
- id: field_0x1f8
  type: u1
- id: field_0x1f9
  type: u1
- id: field_0x1fa
  type: u1
- id: field_0x1fb
  type: u1
- id: field_0x1fc
  type: u1
- id: field_0x1fd
  type: u1
- id: field_0x1fe
  type: u1
- id: field_0x1ff
  type: u1
- id: field_0x200
  type: u1
- id: field_0x201
  type: u1
- id: field_0x202
  type: u1
- id: field_0x203
  type: u1
- id: field_0x204
  type: u1
- id: field_0x205
  type: u1
- id: field_0x206
  type: u1
- id: field_0x207
  type: u1
- id: field_0x208
  type: u1
- id: field_0x209
  type: u1
- id: field_0x20a
  type: u1
- id: field_0x20b
  type: u1
- id: field_0x20c
  type: u1
- id: field_0x20d
  type: u1
- id: field_0x20e
  type: u1
- id: field_0x20f
  type: u1
- id: hp_fractional
  type: u1
- id: field_0x211
  type: u1
- id: field_0x212
  type: u1
- id: field_0x213
  type: u1
- id: unk_exp_tracker
  type: u4
- id: status_icons
  type: status_icon_flags
- id: water_shadow_ripple_tracker
  type: u1
- id: me_first_flag
  type: u1
- id: field_0x222
  type: u1
- id: field_0x223
  type: u1
- id: exclusive_item_offense_boosts
  type: monster_exclusive_item_offense_boosts_array
- id: exclusive_item_defense_boosts
  type: monster_exclusive_item_defense_boosts_array
- id: exclusive_item_effect_flags
  type: monster_exclusive_item_effect_flags_array
- id: field_0x23c
  type: u1
- id: unk_revive_visual_tracker
  type: u1
- id: field_0x23e
  type: u1
- id: should_not_lose_pp
  type: u1
