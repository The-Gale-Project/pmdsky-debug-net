meta:
  id: overlay29_data
  endian: le
  imports:
  - ../types/monster_id
  - ../types/monster_id
  - ../types/move_id
  - ../types/move_id
  - ../types/monster_id
  - ../types/monster_id
  - ../types/monster_id
  - ../types/move_id
  - ../types/move_id
  - ../types/move_id
  - ../types/move_target_and_range
  - ../types/move_id
  - ../types/monster_id
  - ../types/monster_id
  - ../types/monster_id
  - ../types/monster_id
  - ../types/monster_id
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/fixed_room_tile_spawn_table_array
  - ../types/treasure_box_1_item_ids_array
  - ../types/fixed_room_revisit_overrides_array
  - ../types/fixed_room_monster_spawn_table_array
  - ../types/fixed_room_item_spawn_table_array
  - ../types/fixed_room_entity_spawn_table_array
  - ../types/status_icon_array_muzzled_array
  - ../types/status_icon_array_magnet_rise_array
  - ../types/status_icon_array_miracle_eye_array
  - ../types/status_icon_array_leech_seed_array
  - ../types/status_icon_array_long_toss_array
  - ../types/status_icon_array_blinded_array
  - ../types/status_icon_array_burn_array
  - ../types/status_icon_array_sure_shot_array
  - ../types/status_icon_array_invisible_array
  - ../types/status_icon_array_sleep_array
  - ../types/status_icon_array_curse_array
  - ../types/status_icon_array_freeze_array
  - ../types/status_icon_array_cringe_array
  - ../types/status_icon_array_bide_array
  - ../types/status_icon_array_reflect_array
  - ../types/position_displacement_to_direction_array
  - ../types/directions_xy_array
  - ../types/displacements_within_2_largest_first_array
  - ../types/displacements_within_2_smallest_first_array
  - ../types/displacements_within_3_array
  - ../types/item_category_actions_array
  - ../types/fractional_turn_sequence_array
  - ../types/directional_bit_masks_array
  - ../types/directional_bit_masks_array
  - ../types/directional_bit_masks_array
  - ../types/directional_bit_masks_array
  - ../types/directional_bit_masks_array
  - ../types/directional_bit_masks_array
  - ../types/monster_treatment_data_array
  - ../types/fx64_16
  - ../types/fx64_16
  - ../types/fx64_16
  - ../types/fx64_16
  - ../types/fx64_16
  - ../types/fx64_16
  - ../types/fx64_16
  - ../types/fx64_16
  - ../types/type_damage_negating_exclusive_item_effects_array
  - ../types/two_turn_statuses_array
  - ../types/two_turn_moves_and_statuses_array
  - ../types/rollout_damage_mult_table_array
  - ../types/map_color_table_array
  - ../types/corner_cardinal_neighbor_is_open_array
  - ../types/gummi_like_string_ids_array
  - ../types/gummi_iq_string_ids_array
  - ../types/damage_string_ids_array
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/prng_state
  - ../types/dungeon_prng_state_secondary_values_array
  - ../types/excl_item_effects_weather_atk_speed_boost_array
  - ../types/excl_item_effects_weather_move_speed_boost_array
  - ../types/excl_item_effects_weather_no_status_array
  - ../types/excl_item_effects_evasion_boost_array
  - ../types/tile
  - ../types/pointer
  - ../types/pointer
instances:
  dungeon_struct_size_0:
    pos: 0x2838
    type: u4
    doc: Size of the dungeon struct (0x2CB14)
  dungeon_struct_size_1:
    pos: 0x286c
    type: u4
    doc: Size of the dungeon struct (0x2CB14)
  max_hp_cap_0:
    pos: 0x7b90
    type: s4
    doc: The maximum amount of HP a monster can have (999).
  max_hp_cap_1:
    pos: 0x2f578
    type: s4
    doc: The maximum amount of HP a monster can have (999).
  max_hp_cap_2:
    pos: 0x355d4
    type: s4
    doc: The maximum amount of HP a monster can have (999).
  max_hp_cap_3:
    pos: 0x3c214
    type: s4
    doc: The maximum amount of HP a monster can have (999).
  max_hp_cap_4:
    pos: 0x47de0
    type: s4
    doc: The maximum amount of HP a monster can have (999).
  offset_of_dungeon_floor_properties_0:
    pos: 0xb7b8
    type: u4
    doc: Offset of the floor properties field in the dungeon struct (0x286B2)
  offset_of_dungeon_floor_properties_1:
    pos: 0x5ec28
    type: u4
    doc: Offset of the floor properties field in the dungeon struct (0x286B2)
  spawn_rand_max:
    pos: 0xbc10
    type: s4
    doc: Equal to 10,000 (0x2710). Used as parameter for DungeonRandInt to 
      generate the random number which determines the entity to spawn.
  dungeon_prng_lcg_multiplier_0:
    pos: 0xe788
    type: u4
    doc: The multiplier shared by all of the dungeon PRNG's LCGs, 1566083941 
      (0x5D588B65).
  dungeon_prng_lcg_multiplier_1:
    pos: 0xe84c
    type: u4
    doc: The multiplier shared by all of the dungeon PRNG's LCGs, 1566083941 
      (0x5D588B65).
  dungeon_prng_lcg_increment_secondary:
    pos: 0xe854
    type: u4
    doc: The increment for the dungeon PRNG's secondary LCGs, 2531011 
      (0x269EC3). This happens to be the same increment that the Microsoft 
      Visual C++ runtime library uses in its implementation of the rand() 
      function.
  attack_sprite_buffer_size:
    pos: 0x1ac98
    type: s4
    doc: Size of the buffer used to store the current attack sprite file.
  kecleon_female_id:
    pos: 0x1b1c4
    type: monster_id
    doc: 0x3D7 (983). Used when spawning Kecleon on an even numbered floor.
  kecleon_male_id:
    pos: 0x1b1c8
    type: monster_id
    doc: 0x17F (383). Used when spawning Kecleon on an odd numbered floor.
  msg_id_slow_start:
    pos: 0x1d090
    type: s4
    doc: ID of the message printed when a monster has the ability Slow Start at 
      the beginning of the floor.
  experience_point_gain_cap:
    pos: 0x26488
    type: s4
    doc: A cap on the experience that can be given to a monster in one call to 
      AddExpSpecial
  judgment_move_id:
    pos: 0x30218
    type: move_id
    doc: |-
      Move ID for Judgment (0x1D3)

      type: enum move_id
  regular_attack_move_id:
    pos: 0x3021c
    type: move_id
    doc: |-
      Move ID for the regular attack (0x163)

      type: enum move_id
  deoxys_attack_id:
    pos: 0x30220
    type: monster_id
    doc: |-
      Monster ID for Deoxys in Attack Forme (0x1A3)

      type: enum monster_id
  deoxys_speed_id:
    pos: 0x30224
    type: monster_id
    doc: |-
      Monster ID for Deoxys in Speed Forme (0x1A5)

      type: enum monster_id
  giratina_altered_id:
    pos: 0x30228
    type: monster_id
    doc: |-
      Monster ID for Giratina in Altered Forme (0x211)

      type: enum monster_id
  punishment_move_id:
    pos: 0x3022c
    type: move_id
    doc: |-
      Move ID for Punishment (0x1BD)

      type: enum move_id
  offense_stat_max:
    pos: 0x3025c
    type: s4
    doc: Cap on an attacker's modified offense (attack or special attack) stat 
      after boosts. Used during damage calculation.
  projectile_move_id_0:
    pos: 0x30e3c
    type: move_id
    doc: |-
      The move ID of the special "projectile" move (0x195)

      type: enum move_id
  projectile_move_id_1:
    pos: 0x404c0
    type: move_id
    doc: |-
      The move ID of the special "projectile" move (0x195)

      type: enum move_id
  belly_lost_per_turn:
    pos: 0x34830
    type: s4
    doc: |-
      The base value by which belly is decreased every turn.

      Its raw value is 0x199A, which encodes a binary fixed-point number (16 fraction bits) with value (0x199A * 2^-16), and is the closest approximation to 0.1 representable in this number format.
  monster_heal_hp_max:
    pos: 0x390a0
    type: s4
    doc: The maximum amount of HP a monster can have (999).
  move_target_and_range_special_user_healing:
    pos: 0x3eaf4
    type: move_target_and_range
    doc: |-
      The move target and range code for special healing moves that target just the user (0x273).

      type: struct move_target_and_range (+ padding)
  plain_seed_string_id:
    pos: 0x40508
    type: s4
    doc: The string ID for eating a Plain Seed (0xBE9).
  max_elixir_pp_restoration:
    pos: 0x4050c
    type: s4
    doc: The amount of PP restored per move by ingesting a Max Elixir (0x3E7).
  slip_seed_fail_string_id:
    pos: 0x4096c
    type: s4
    doc: The string ID for when eating the Slip Seed fails (0xC75).
  rock_wrecker_move_id:
    pos: 0x48360
    type: move_id
    doc: The move ID for Rock Wrecker (453).
  castform_normal_form_male_id:
    pos: 0x591f8
    type: monster_id
    doc: Castform's male normal form ID (0x17B)
  castform_normal_form_female_id:
    pos: 0x591fc
    type: monster_id
    doc: Castform's female normal form ID (0x3D3)
  cherrim_sunshine_form_male_id:
    pos: 0x59200
    type: monster_id
    doc: Cherrim's male sunshine form ID (0x1CD)
  cherrim_overcast_form_female_id:
    pos: 0x59204
    type: monster_id
    doc: Cherrim's female overcast form ID (0x424)
  cherrim_sunshine_form_female_id:
    pos: 0x59208
    type: monster_id
    doc: Cherrim's female sunshine form ID (0x425)
  floor_generation_status_ptr_0:
    pos: 0x5ec2c
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_1:
    pos: 0x5ecc8
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_2:
    pos: 0x5ef4c
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_3:
    pos: 0x5f3d8
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_4:
    pos: 0x5f838
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_5:
    pos: 0x5f998
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_6:
    pos: 0x5fb30
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_7:
    pos: 0x5fcec
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_8:
    pos: 0x600cc
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_9:
    pos: 0x6052c
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_10:
    pos: 0x60d40
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_11:
    pos: 0x60ec0
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_12:
    pos: 0x610d0
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_13:
    pos: 0x61430
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_14:
    pos: 0x61e18
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_15:
    pos: 0x63d50
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_16:
    pos: 0x63fdc
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_17:
    pos: 0x64490
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_18:
    pos: 0x6521c
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_19:
    pos: 0x65524
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_20:
    pos: 0x65f38
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_21:
    pos: 0x662d0
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_22:
    pos: 0x665a0
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_23:
    pos: 0x66934
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_24:
    pos: 0x66a24
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_25:
    pos: 0x66b58
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  floor_generation_status_ptr_26:
    pos: 0x66ce8
    type: pointer
    doc: |-
      Pointer to the global FLOOR_GENERATION_STATUS

      type: struct floor_generation_status*
  offset_of_dungeon_n_normal_item_spawns_0:
    pos: 0x5ec34
    type: u4
    doc: Offset of the (number of base items + 1) field on the dungeon struct 
      (0x12AFA)
  offset_of_dungeon_n_normal_item_spawns_1:
    pos: 0x65224
    type: u4
    doc: Offset of the (number of base items + 1) field on the dungeon struct 
      (0x12AFA)
  dungeon_grid_column_bytes_0:
    pos: 0x5f3d4
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_1:
    pos: 0x5f834
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_2:
    pos: 0x5fb2c
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_3:
    pos: 0x5fce8
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_4:
    pos: 0x600c8
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_5:
    pos: 0x60530
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_6:
    pos: 0x607a4
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_7:
    pos: 0x60d38
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_8:
    pos: 0x60ebc
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_9:
    pos: 0x610d4
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_10:
    pos: 0x6142c
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_11:
    pos: 0x61e14
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_12:
    pos: 0x621f8
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_13:
    pos: 0x62af0
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_14:
    pos: 0x62ed4
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_15:
    pos: 0x636bc
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_16:
    pos: 0x63d54
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_17:
    pos: 0x63fe0
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_18:
    pos: 0x64214
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  dungeon_grid_column_bytes_19:
    pos: 0x6628c
    type: u4
    doc: The number of bytes in one column of the dungeon grid cell array, 450, 
      which corresponds to a column of 15 grid cells.
  default_max_position:
    pos: 0x63d58
    type: s4
    doc: A large number (9999) to use as a default position for keeping track of
      min/max position values
  offset_of_dungeon_guaranteed_item_id_0:
    pos: 0x65220
    type: u4
    doc: Offset of the guaranteed item ID field in the dungeon struct (0x2C9E8)
  offset_of_dungeon_guaranteed_item_id_1:
    pos: 0x68c40
    type: u4
    doc: Offset of the guaranteed item ID field in the dungeon struct (0x2C9E8)
  fixed_room_tile_spawn_table:
    pos: 0x73b90
    type: fixed_room_tile_spawn_table_array
    doc: |-
      Table of tiles that can spawn in fixed rooms, pointed into by the FIXED_ROOM_TILE_SPAWN_TABLE.

      This is an array of 11 4-byte entries containing info about one tile each. Info includes the trap ID if a trap, room ID, and flags.

      type: struct fixed_room_tile_spawn_entry[11]
  treasure_box_1_item_ids:
    pos: 0x73bbc
    type: treasure_box_1_item_ids_array
    doc: |-
      Item IDs for variant 1 of each of the treasure box items (ITEM_*_BOX_1).

      type: struct item_id_16[12]
  fixed_room_revisit_overrides:
    pos: 0x73bd4
    type: fixed_room_revisit_overrides_array
    doc: |-
      Table of fixed room IDs, which if nonzero, overrides the normal fixed room ID for a floor (which is used to index the table) if the dungeon has already been cleared previously.

      Overrides are used to substitute different fixed room data for things like revisits to story dungeons.

      type: struct fixed_room_id_8[256]
  fixed_room_monster_spawn_table:
    pos: 0x73cd4
    type: fixed_room_monster_spawn_table_array
    doc: |-
      Table of monsters that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.

      This is an array of 120 4-byte entries containing info about one monster each. Info includes the monster ID, stats, and behavior type.

      type: struct fixed_room_monster_spawn_entry[120]
  fixed_room_item_spawn_table:
    pos: 0x73eb4
    type: fixed_room_item_spawn_table_array
    doc: |-
      Table of items that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.

      This is an array of 63 8-byte entries containing one item ID each.

      type: struct fixed_room_item_spawn_entry[63]
  fixed_room_entity_spawn_table:
    pos: 0x740ac
    type: fixed_room_entity_spawn_table_array
    doc: |-
      Table of entities (items, monsters, tiles) that can spawn in fixed rooms, which is indexed into by the main data structure for each fixed room.

      This is an array of 269 entries. Each entry contains 3 pointers (one into FIXED_ROOM_ITEM_SPAWN_TABLE, one into FIXED_ROOM_MONSTER_SPAWN_TABLE, and one into FIXED_ROOM_TILE_SPAWN_TABLE), and represents the entities that can spawn on one specific tile in a fixed room.

      type: struct fixed_room_entity_spawn_entry[269]
  status_icon_array_muzzled:
    pos: 0x74f7c
    type: status_icon_array_muzzled_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::muzzled * 8. See UpdateStatusIconFlags for details.
  status_icon_array_magnet_rise:
    pos: 0x74f8c
    type: status_icon_array_magnet_rise_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::magnet_rise * 8. See UpdateStatusIconFlags for details.
  status_icon_array_miracle_eye:
    pos: 0x74fac
    type: status_icon_array_miracle_eye_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::miracle_eye * 8. See UpdateStatusIconFlags for details.
  status_icon_array_leech_seed:
    pos: 0x74fbc
    type: status_icon_array_leech_seed_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::leech_seed * 8. See UpdateStatusIconFlags for details.
  status_icon_array_long_toss:
    pos: 0x74fd4
    type: status_icon_array_long_toss_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::long_toss * 8. See UpdateStatusIconFlags for details.
  status_icon_array_blinded:
    pos: 0x7502c
    type: status_icon_array_blinded_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::blinded * 8. See UpdateStatusIconFlags for details.
  status_icon_array_burn:
    pos: 0x75054
    type: status_icon_array_burn_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::burn * 8. See UpdateStatusIconFlags for details.
  status_icon_array_sure_shot:
    pos: 0x7507c
    type: status_icon_array_sure_shot_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::sure_shot * 8. See UpdateStatusIconFlags for details.
  status_icon_array_invisible:
    pos: 0x750a4
    type: status_icon_array_invisible_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::invisible * 8. See UpdateStatusIconFlags for details.
  status_icon_array_sleep:
    pos: 0x750cc
    type: status_icon_array_sleep_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::sleep * 8. See UpdateStatusIconFlags for details.
  status_icon_array_curse:
    pos: 0x750fc
    type: status_icon_array_curse_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::curse * 8. See UpdateStatusIconFlags for details.
  status_icon_array_freeze:
    pos: 0x75134
    type: status_icon_array_freeze_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::freeze * 8. See UpdateStatusIconFlags for details.
  status_icon_array_cringe:
    pos: 0x75174
    type: status_icon_array_cringe_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::cringe * 8. See UpdateStatusIconFlags for details.
  status_icon_array_bide:
    pos: 0x751b4
    type: status_icon_array_bide_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::bide * 8. See UpdateStatusIconFlags for details.
  status_icon_array_reflect:
    pos: 0x752b4
    type: status_icon_array_reflect_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::reflect * 8. See UpdateStatusIconFlags for details.
  position_displacement_to_direction:
    pos: 0x753c4
    type: position_displacement_to_direction_array
    doc: |-
      An array mapping position displacements (y, then x) to directions. Used by GetDirectionTowardsPosition.

      Given two positions, displacements are either 0, 1, or 2 depending on whether the second position's x/y coordinate is less than, equal, or greater
      than the first position's corresponding coordinates. For example, POSITION_DISPLACEMENT_TO_DIRECTION[0][2] (DIR_UP_RIGHT)
      indicates that the second y coordinate is less than the first, and the second x coordinate is greater than the first.
  directions_xy:
    pos: 0x754dc
    type: directions_xy_array
    doc: |-
      An array mapping each direction index to its x and y displacements.

      Directions start with 0=down and proceed counterclockwise (see enum direction_id). Displacements for x and y are interleaved and encoded as 2-byte signed integers. For example, the first two integers are [0, 1], which correspond to the x and y displacements for the "down" direction (positive y means down).
  displacements_within_2_largest_first:
    pos: 0x7559c
    type: displacements_within_2_largest_first_array
    doc: |-
      An array of displacement vectors with max norm <= 2, ordered in descending order by norm.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[26]
  displacements_within_2_smallest_first:
    pos: 0x75604
    type: displacements_within_2_smallest_first_array
    doc: |-
      An array of displacement vectors with max norm <= 2, ordered in ascending order by norm.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[26]
  displacements_within_3:
    pos: 0x7566c
    type: displacements_within_3_array
    doc: |-
      An array of displacement vectors with max norm <= 3. The elements are vaguely in ascending order by norm, but not exactly.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[50]
  item_category_actions:
    pos: 0x75dd0
    type: item_category_actions_array
    doc: |-
      Action ID associated with each item category. Used by GetItemAction.

      Each entry is 2 bytes long.
  fractional_turn_sequence:
    pos: 0x76044
    type: fractional_turn_sequence_array
    doc: |-
      Read by certain functions that are called by RunFractionalTurn to see if they should be executed.

      Array is accessed via a pointer added to some multiple of fractional_turn, so that if the resulting memory location is zero, the function returns.
  belly_drain_in_walls_int:
    pos: 0x76528
    type: u2
    doc: The additional amount by which belly is decreased every turn when 
      inside walls (integer part)
  belly_drain_in_walls_thousandths:
    pos: 0x7652a
    type: u2
    doc: The additional amount by which belly is decreased every turn when 
      inside walls (fractional thousandths)
  directional_bit_masks_0:
    pos: 0x76530
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_1:
    pos: 0x76538
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_2:
    pos: 0x76540
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_3:
    pos: 0x76548
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_4:
    pos: 0x76550
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_5:
    pos: 0x76558
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  monster_treatment_data:
    pos: 0x76560
    type: monster_treatment_data_array
    doc: |-
      A 4D array of monster_treatment enum values. Used by GetTreatmentBetweenMonsters to determine treatment based on several parameters.
      The parameters are (in order of how the array is indexed):
      1. Value from 0-3 based on entity1's decoy_ai_tracker value.
        If decoy_ai_tracker is 0 and the entity is the leader, this value is 0. Otherwise it is decoy_ai_tracker + 1
      2. Boolean value for whether entity1 is a wild Pokémon.
      3. Boolean value for whether entity2 is a wild Pokémon.
      4. Boolean value for whether entity2 is a decoy.
  damage_multiplier_0_5:
    pos: 0x765fc
    type: fx64_16
    doc: A generic damage multiplier of 0.5 used in various places, as a 64-bit 
      fixed-point number with 16 fraction bits.
  damage_multiplier_1_5:
    pos: 0x76604
    type: fx64_16
    doc: A generic damage multiplier of 1.5 used in various places, as a 64-bit 
      fixed-point number with 16 fraction bits.
  damage_multiplier_2:
    pos: 0x7660c
    type: fx64_16
    doc: A generic damage multiplier of 2 used in various places, as a 64-bit 
      fixed-point number with 16 fraction bits.
  cloudy_damage_multiplier:
    pos: 0x7661c
    type: fx64_16
    doc: The extra damage multiplier for non-Normal-type moves when the weather 
      is Cloudy, as a 64-bit fixed-point number with 16 fraction bits (0.75).
  solid_rock_multiplier:
    pos: 0x76624
    type: fx64_16
    doc: The extra damage multiplier for super-effective moves when Solid Rock 
      or Filter is active, as a 64-bit fixed-point number with 16 fraction bits 
      (0.75).
  damage_formula_max_base:
    pos: 0x7662c
    type: fx64_16
    doc: The maximum value of the base damage formula (after 
      DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER application, if relevant), as a 
      64-bit binary fixed-point number with 16 fraction bits (999).
  wonder_guard_multiplier:
    pos: 0x76634
    type: fx64_16
    doc: The damage multiplier for moves affected by Wonder Guard, as a 64-bit 
      fixed-point number with 16 fraction bits (0).
  damage_formula_min_base:
    pos: 0x7663c
    type: fx64_16
    doc: The minimum value of the base damage formula (after 
      DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER application, if relevant), as a 
      64-bit binary fixed-point number with 16 fraction bits (1).
  type_damage_negating_exclusive_item_effects:
    pos: 0x76664
    type: type_damage_negating_exclusive_item_effects_array
    doc: |-
      List of exclusive item effects that negate damage of a certain type, terminated by a TYPE_NEUTRAL entry.

      type: struct damage_negating_exclusive_eff_entry[28]
  two_turn_statuses:
    pos: 0x76820
    type: two_turn_statuses_array
    doc: Lists all status IDs that are for two-turn moves. The last entry is 
      null.
  two_turn_moves_and_statuses:
    pos: 0x7686c
    type: two_turn_moves_and_statuses_array
    doc: List that matches two-turn move IDs to their corresponding status ID. 
      The last entry is null.
  spatk_stat_idx:
    pos: 0x768a8
    type: s4
    doc: The index (1) of the special attack entry in internal stat structs, 
      such as the stat modifier array for a monster.
  atk_stat_idx:
    pos: 0x768ac
    type: s4
    doc: The index (0) of the attack entry in internal stat structs, such as the
      stat modifier array for a monster.
  rollout_damage_mult_table:
    pos: 0x768b0
    type: rollout_damage_mult_table_array
    doc: |-
      A table of damage multipliers for each successive hit of Rollout/Ice Ball. Each entry is a binary fixed-point number with 8 fraction bits.

      type: int32_t[10]
  map_color_table:
    pos: 0x76d90
    type: map_color_table_array
    doc: |-
      In order: white, black, red, green, blue, magenta, dark pink, chartreuse, light orange

      Note: unverified, ported from Irdkwia's notes

      type: struct rgba[9]
  corner_cardinal_neighbor_is_open:
    pos: 0x76dd0
    type: corner_cardinal_neighbor_is_open_array
    doc: |-
      An array mapping each (corner index, neighbor direction index) to whether or not that neighbor is expected to be open floor.

      Corners start with 0=top-left and proceed clockwise. Directions are enumerated as with DIRECTIONS_XY. The array is indexed by i=(corner_index * N_DIRECTIONS + direction). An element of 1 (0) means that starting from the specified corner of a room, moving in the specified direction should lead to an open floor tile (non-open terrain like a wall).

      Note that this array is only used for the cardinal directions. The elements at odd indexes are unused and unconditionally set to 0.

      This array is used by the dungeon generation algorithm when generating room imperfections. See GenerateRoomImperfections.
  gummi_like_string_ids:
    pos: 0x77090
    type: gummi_like_string_ids_array
    doc: List that holds the string IDs for how much a monster liked a gummi in 
      decreasing order.
  gummi_iq_string_ids:
    pos: 0x770e4
    type: gummi_iq_string_ids_array
    doc: List that holds the string IDs for how much a monster's IQ was raised 
      by in decreasing order.
  damage_string_ids:
    pos: 0x770f0
    type: damage_string_ids_array
    doc: List that matches the damage_message ID to their corresponding string 
      ID. The null entry at 0xE in the middle is for hunger. The last entry is 
      null.
  dungeon_ptr:
    pos: 0x772f8
    type: pointer
    doc: |-
      [Runtime] Pointer to the dungeon struct in dungeon mode.

      This is a "working copy" of DUNGEON_PTR_MASTER. The main dungeon engine uses this pointer (or rather pointers to this pointer) when actually running dungeon mode.

      type: struct dungeon*
  dungeon_ptr_master:
    pos: 0x772fc
    type: pointer
    doc: |-
      [Runtime] Pointer to the dungeon struct in dungeon mode.

      This is a "master copy" of the dungeon pointer. The game uses this pointer when doing low-level memory work (allocation, freeing, zeroing). The normal DUNGEON_PTR is used for most other dungeon mode work.

      type: struct dungeon*
  top_screen_status_ptr:
    pos: 0x77314
    type: pointer
    doc: |-
      [Runtime] Pointer for struct for handling the status of the top screen in dungeon mode.

      type: struct top_screen_status
  leader_ptr:
    pos: 0x7731c
    type: pointer
    doc: |-
      [Runtime] Pointer to the current leader of the team.

      type: struct entity*
  dungeon_prng_state:
    pos: 0x77330
    type: prng_state
    doc: |-
      [Runtime] The global PRNG state for dungeon mode, not including the current values in the secondary sequences.

      This struct holds state for the primary LCG, as well as the current configuration controlling which LCG to use when generating random numbers. See DungeonRand16Bit for more information on how the dungeon PRNG works.

      type: struct prng_state
  dungeon_prng_state_secondary_values:
    pos: 0x77344
    type: dungeon_prng_state_secondary_values_array
    doc: |-
      [Runtime] An array of 5 integers corresponding to the last value generated for each secondary LCG sequence.

      Based on the assembly, this appears to be its own global array, separate from DUNGEON_PRNG_STATE.
  loaded_attack_sprite_file_index:
    pos: 0x7736c
    type: u2
    doc: |-
      [Runtime] The file index of the currently loaded attack sprite.

      type: uint16_t
  excl_item_effects_weather_atk_speed_boost:
    pos: 0x77370
    type: excl_item_effects_weather_atk_speed_boost_array
    doc: Array of IDs for exclusive item effects that increase attack speed with
      certain weather conditions.
  excl_item_effects_weather_move_speed_boost:
    pos: 0x77378
    type: excl_item_effects_weather_move_speed_boost_array
    doc: Array of IDs for exclusive item effects that increase movement speed 
      with certain weather conditions.
  excl_item_effects_weather_no_status:
    pos: 0x77380
    type: excl_item_effects_weather_no_status_array
    doc: Array of IDs for exclusive item effects that grant status immunity with
      certain weather conditions.
  ai_thrown_item_action_choice_count:
    pos: 0x774bc
    type: u4
    doc: '[Runtime] Used to store the number of positions output by GetPossibleAiArcItemTargets
      and the number of directions/probabilities output by GetPossibleAiThrownItemDirections.'
  excl_item_effects_evasion_boost:
    pos: 0x774d0
    type: excl_item_effects_evasion_boost_array
    doc: Array of IDs for exclusive item effects that grant an evasion boost 
      with certain weather conditions.
  default_tile:
    pos: 0x774e4
    type: tile
    doc: |-
      The default tile struct.

      This is just a struct full of zeroes, but is used as a fallback in various places where a "default" tile is needed, such as when a grid index is out of range.

      type: struct tile
  hidden_stairs_spawn_blocked:
    pos: 0x7754c
    type: u1
    doc: |-
      [Runtime] A flag for when Hidden Stairs could normally have spawned on the floor but didn't.

      This is set either when the Hidden Stairs just happen not to spawn by chance, or when the current floor is a rescue or mission destination floor.

      This appears to be part of a larger (8-byte?) struct. It seems like this value is at least followed by 3 bytes of padding and a 4-byte integer field.
  fixed_room_data_ptr:
    pos: 0x77554
    type: pointer
    doc: '[Runtime] Pointer to decoded fixed room data loaded from the BALANCE/fixed.bin
      file.'
  dungeon_fades_ptr:
    pos: 0x775a0
    type: pointer
    doc: '[Runtime] Pointer to the dungeon fades struct that maintains the status
      of screen fades in dungeon mode.'
