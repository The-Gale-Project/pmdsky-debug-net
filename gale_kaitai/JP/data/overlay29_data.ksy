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
  - ../types/monster_id
  - ../types/monster_id
  - ../types/monster_id
  - ../types/monster_id
  - ../types/monster_id
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
  attack_sprite_buffer_size:
    pos: 0x1abc8
    type: s4
    doc: Size of the buffer used to store the current attack sprite file.
  kecleon_female_id:
    pos: 0x1b0ec
    type: monster_id
    doc: 0x3D7 (983). Used when spawning Kecleon on an even numbered floor.
  kecleon_male_id:
    pos: 0x1b0f0
    type: monster_id
    doc: 0x17F (383). Used when spawning Kecleon on an odd numbered floor.
  judgment_move_id:
    pos: 0x300c8
    type: move_id
    doc: |-
      Move ID for Judgment (0x1D3)

      type: enum move_id
  regular_attack_move_id:
    pos: 0x300cc
    type: move_id
    doc: |-
      Move ID for the regular attack (0x163)

      type: enum move_id
  deoxys_attack_id:
    pos: 0x300d0
    type: monster_id
    doc: |-
      Monster ID for Deoxys in Attack Forme (0x1A3)

      type: enum monster_id
  deoxys_speed_id:
    pos: 0x300d4
    type: monster_id
    doc: |-
      Monster ID for Deoxys in Speed Forme (0x1A5)

      type: enum monster_id
  giratina_altered_id:
    pos: 0x300d8
    type: monster_id
    doc: |-
      Monster ID for Giratina in Altered Forme (0x211)

      type: enum monster_id
  punishment_move_id:
    pos: 0x300dc
    type: move_id
    doc: |-
      Move ID for Punishment (0x1BD)

      type: enum move_id
  belly_lost_per_turn:
    pos: 0x346b8
    type: s4
    doc: |-
      The base value by which belly is decreased every turn.

      Its raw value is 0x199A, which encodes a binary fixed-point number (16 fraction bits) with value (0x199A * 2^-16), and is the closest approximation to 0.1 representable in this number format.
  castform_normal_form_male_id:
    pos: 0x58f44
    type: monster_id
    doc: Castform's male normal form ID (0x17B)
  castform_normal_form_female_id:
    pos: 0x58f48
    type: monster_id
    doc: Castform's female normal form ID (0x3D3)
  cherrim_sunshine_form_male_id:
    pos: 0x58f4c
    type: monster_id
    doc: Cherrim's male sunshine form ID (0x1CD)
  cherrim_overcast_form_female_id:
    pos: 0x58f50
    type: monster_id
    doc: Cherrim's female overcast form ID (0x424)
  cherrim_sunshine_form_female_id:
    pos: 0x58f54
    type: monster_id
    doc: Cherrim's female sunshine form ID (0x425)
  fixed_room_tile_spawn_table:
    pos: 0x73770
    type: fixed_room_tile_spawn_table_array
    doc: |-
      Table of tiles that can spawn in fixed rooms, pointed into by the FIXED_ROOM_TILE_SPAWN_TABLE.

      This is an array of 11 4-byte entries containing info about one tile each. Info includes the trap ID if a trap, room ID, and flags.

      type: struct fixed_room_tile_spawn_entry[11]
  treasure_box_1_item_ids:
    pos: 0x7379c
    type: treasure_box_1_item_ids_array
    doc: |-
      Item IDs for variant 1 of each of the treasure box items (ITEM_*_BOX_1).

      type: struct item_id_16[12]
  fixed_room_revisit_overrides:
    pos: 0x737b4
    type: fixed_room_revisit_overrides_array
    doc: |-
      Table of fixed room IDs, which if nonzero, overrides the normal fixed room ID for a floor (which is used to index the table) if the dungeon has already been cleared previously.

      Overrides are used to substitute different fixed room data for things like revisits to story dungeons.

      type: struct fixed_room_id_8[256]
  fixed_room_monster_spawn_table:
    pos: 0x738b4
    type: fixed_room_monster_spawn_table_array
    doc: |-
      Table of monsters that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.

      This is an array of 120 4-byte entries containing info about one monster each. Info includes the monster ID, stats, and behavior type.

      type: struct fixed_room_monster_spawn_entry[120]
  fixed_room_item_spawn_table:
    pos: 0x73a94
    type: fixed_room_item_spawn_table_array
    doc: |-
      Table of items that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.

      This is an array of 63 8-byte entries containing one item ID each.

      type: struct fixed_room_item_spawn_entry[63]
  fixed_room_entity_spawn_table:
    pos: 0x73c8c
    type: fixed_room_entity_spawn_table_array
    doc: |-
      Table of entities (items, monsters, tiles) that can spawn in fixed rooms, which is indexed into by the main data structure for each fixed room.

      This is an array of 269 entries. Each entry contains 3 pointers (one into FIXED_ROOM_ITEM_SPAWN_TABLE, one into FIXED_ROOM_MONSTER_SPAWN_TABLE, and one into FIXED_ROOM_TILE_SPAWN_TABLE), and represents the entities that can spawn on one specific tile in a fixed room.

      type: struct fixed_room_entity_spawn_entry[269]
  status_icon_array_muzzled:
    pos: 0x74b5c
    type: status_icon_array_muzzled_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::muzzled * 8. See UpdateStatusIconFlags for details.
  status_icon_array_magnet_rise:
    pos: 0x74b6c
    type: status_icon_array_magnet_rise_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::magnet_rise * 8. See UpdateStatusIconFlags for details.
  status_icon_array_miracle_eye:
    pos: 0x74b8c
    type: status_icon_array_miracle_eye_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::miracle_eye * 8. See UpdateStatusIconFlags for details.
  status_icon_array_leech_seed:
    pos: 0x74b9c
    type: status_icon_array_leech_seed_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::leech_seed * 8. See UpdateStatusIconFlags for details.
  status_icon_array_long_toss:
    pos: 0x74bb4
    type: status_icon_array_long_toss_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::long_toss * 8. See UpdateStatusIconFlags for details.
  status_icon_array_blinded:
    pos: 0x74c0c
    type: status_icon_array_blinded_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::blinded * 8. See UpdateStatusIconFlags for details.
  status_icon_array_burn:
    pos: 0x74c34
    type: status_icon_array_burn_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::burn * 8. See UpdateStatusIconFlags for details.
  status_icon_array_sure_shot:
    pos: 0x74c5c
    type: status_icon_array_sure_shot_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::sure_shot * 8. See UpdateStatusIconFlags for details.
  status_icon_array_invisible:
    pos: 0x74c84
    type: status_icon_array_invisible_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::invisible * 8. See UpdateStatusIconFlags for details.
  status_icon_array_sleep:
    pos: 0x74cac
    type: status_icon_array_sleep_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::sleep * 8. See UpdateStatusIconFlags for details.
  status_icon_array_curse:
    pos: 0x74cdc
    type: status_icon_array_curse_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::curse * 8. See UpdateStatusIconFlags for details.
  status_icon_array_freeze:
    pos: 0x74d14
    type: status_icon_array_freeze_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::freeze * 8. See UpdateStatusIconFlags for details.
  status_icon_array_cringe:
    pos: 0x74d54
    type: status_icon_array_cringe_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::cringe * 8. See UpdateStatusIconFlags for details.
  status_icon_array_bide:
    pos: 0x74d94
    type: status_icon_array_bide_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::bide * 8. See UpdateStatusIconFlags for details.
  status_icon_array_reflect:
    pos: 0x74e94
    type: status_icon_array_reflect_array
    doc: Array of bit masks used to set monster::status_icon. Indexed by 
      monster::statuses::reflect * 8. See UpdateStatusIconFlags for details.
  position_displacement_to_direction:
    pos: 0x74fa4
    type: position_displacement_to_direction_array
    doc: |-
      An array mapping position displacements (y, then x) to directions. Used by GetDirectionTowardsPosition.

      Given two positions, displacements are either 0, 1, or 2 depending on whether the second position's x/y coordinate is less than, equal, or greater
      than the first position's corresponding coordinates. For example, POSITION_DISPLACEMENT_TO_DIRECTION[0][2] (DIR_UP_RIGHT)
      indicates that the second y coordinate is less than the first, and the second x coordinate is greater than the first.
  directions_xy:
    pos: 0x750bc
    type: directions_xy_array
    doc: |-
      An array mapping each direction index to its x and y displacements.

      Directions start with 0=down and proceed counterclockwise (see enum direction_id). Displacements for x and y are interleaved and encoded as 2-byte signed integers. For example, the first two integers are [0, 1], which correspond to the x and y displacements for the "down" direction (positive y means down).
  displacements_within_2_largest_first:
    pos: 0x7517c
    type: displacements_within_2_largest_first_array
    doc: |-
      An array of displacement vectors with max norm <= 2, ordered in descending order by norm.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[26]
  displacements_within_2_smallest_first:
    pos: 0x751e4
    type: displacements_within_2_smallest_first_array
    doc: |-
      An array of displacement vectors with max norm <= 2, ordered in ascending order by norm.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[26]
  displacements_within_3:
    pos: 0x7524c
    type: displacements_within_3_array
    doc: |-
      An array of displacement vectors with max norm <= 3. The elements are vaguely in ascending order by norm, but not exactly.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[50]
  item_category_actions:
    pos: 0x759b0
    type: item_category_actions_array
    doc: |-
      Action ID associated with each item category. Used by GetItemAction.

      Each entry is 2 bytes long.
  fractional_turn_sequence:
    pos: 0x75c24
    type: fractional_turn_sequence_array
    doc: |-
      Read by certain functions that are called by RunFractionalTurn to see if they should be executed.

      Array is accessed via a pointer added to some multiple of fractional_turn, so that if the resulting memory location is zero, the function returns.
  belly_drain_in_walls_int:
    pos: 0x76108
    type: u2
    doc: The additional amount by which belly is decreased every turn when 
      inside walls (integer part)
  belly_drain_in_walls_thousandths:
    pos: 0x7610a
    type: u2
    doc: The additional amount by which belly is decreased every turn when 
      inside walls (fractional thousandths)
  directional_bit_masks_0:
    pos: 0x76110
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_1:
    pos: 0x76118
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_2:
    pos: 0x76120
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_3:
    pos: 0x76128
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_4:
    pos: 0x76130
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  directional_bit_masks_5:
    pos: 0x76138
    type: directional_bit_masks_array
    doc: An array of one-hot bit masks corresponding to each direction_id. Used 
      alongside tile->walkable_neighbor_flags to determine whether it's possible
      to move to a tile.
  monster_treatment_data:
    pos: 0x76140
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
    pos: 0x761dc
    type: fx64_16
    doc: A generic damage multiplier of 0.5 used in various places, as a 64-bit 
      fixed-point number with 16 fraction bits.
  damage_multiplier_1_5:
    pos: 0x761e4
    type: fx64_16
    doc: A generic damage multiplier of 1.5 used in various places, as a 64-bit 
      fixed-point number with 16 fraction bits.
  damage_multiplier_2:
    pos: 0x761ec
    type: fx64_16
    doc: A generic damage multiplier of 2 used in various places, as a 64-bit 
      fixed-point number with 16 fraction bits.
  cloudy_damage_multiplier:
    pos: 0x761fc
    type: fx64_16
    doc: The extra damage multiplier for non-Normal-type moves when the weather 
      is Cloudy, as a 64-bit fixed-point number with 16 fraction bits (0.75).
  solid_rock_multiplier:
    pos: 0x76204
    type: fx64_16
    doc: The extra damage multiplier for super-effective moves when Solid Rock 
      or Filter is active, as a 64-bit fixed-point number with 16 fraction bits 
      (0.75).
  damage_formula_max_base:
    pos: 0x7620c
    type: fx64_16
    doc: The maximum value of the base damage formula (after 
      DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER application, if relevant), as a 
      64-bit binary fixed-point number with 16 fraction bits (999).
  damage_formula_min_base:
    pos: 0x7621c
    type: fx64_16
    doc: The minimum value of the base damage formula (after 
      DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER application, if relevant), as a 
      64-bit binary fixed-point number with 16 fraction bits (1).
  type_damage_negating_exclusive_item_effects:
    pos: 0x76244
    type: type_damage_negating_exclusive_item_effects_array
    doc: |-
      List of exclusive item effects that negate damage of a certain type, terminated by a TYPE_NEUTRAL entry.

      type: struct damage_negating_exclusive_eff_entry[28]
  two_turn_statuses:
    pos: 0x76400
    type: two_turn_statuses_array
    doc: Lists all status IDs that are for two-turn moves. The last entry is 
      null.
  two_turn_moves_and_statuses:
    pos: 0x7644c
    type: two_turn_moves_and_statuses_array
    doc: List that matches two-turn move IDs to their corresponding status ID. 
      The last entry is null.
  spatk_stat_idx:
    pos: 0x76488
    type: s4
    doc: The index (1) of the special attack entry in internal stat structs, 
      such as the stat modifier array for a monster.
  atk_stat_idx:
    pos: 0x7648c
    type: s4
    doc: The index (0) of the attack entry in internal stat structs, such as the
      stat modifier array for a monster.
  rollout_damage_mult_table:
    pos: 0x76490
    type: rollout_damage_mult_table_array
    doc: |-
      A table of damage multipliers for each successive hit of Rollout/Ice Ball. Each entry is a binary fixed-point number with 8 fraction bits.

      type: int32_t[10]
  map_color_table:
    pos: 0x76970
    type: map_color_table_array
    doc: |-
      In order: white, black, red, green, blue, magenta, dark pink, chartreuse, light orange

      Note: unverified, ported from Irdkwia's notes

      type: struct rgba[9]
  corner_cardinal_neighbor_is_open:
    pos: 0x769b0
    type: corner_cardinal_neighbor_is_open_array
    doc: |-
      An array mapping each (corner index, neighbor direction index) to whether or not that neighbor is expected to be open floor.

      Corners start with 0=top-left and proceed clockwise. Directions are enumerated as with DIRECTIONS_XY. The array is indexed by i=(corner_index * N_DIRECTIONS + direction). An element of 1 (0) means that starting from the specified corner of a room, moving in the specified direction should lead to an open floor tile (non-open terrain like a wall).

      Note that this array is only used for the cardinal directions. The elements at odd indexes are unused and unconditionally set to 0.

      This array is used by the dungeon generation algorithm when generating room imperfections. See GenerateRoomImperfections.
  gummi_like_string_ids:
    pos: 0x76c70
    type: gummi_like_string_ids_array
    doc: List that holds the string IDs for how much a monster liked a gummi in 
      decreasing order.
  gummi_iq_string_ids:
    pos: 0x76cc4
    type: gummi_iq_string_ids_array
    doc: List that holds the string IDs for how much a monster's IQ was raised 
      by in decreasing order.
  damage_string_ids:
    pos: 0x76cd0
    type: damage_string_ids_array
    doc: List that matches the damage_message ID to their corresponding string 
      ID. The null entry at 0xE in the middle is for hunger. The last entry is 
      null.
  dungeon_ptr:
    pos: 0x76ed8
    type: pointer
    doc: |-
      [Runtime] Pointer to the dungeon struct in dungeon mode.

      This is a "working copy" of DUNGEON_PTR_MASTER. The main dungeon engine uses this pointer (or rather pointers to this pointer) when actually running dungeon mode.

      type: struct dungeon*
  top_screen_status_ptr:
    pos: 0x76ef4
    type: pointer
    doc: |-
      [Runtime] Pointer for struct for handling the status of the top screen in dungeon mode.

      type: struct top_screen_status
  leader_ptr:
    pos: 0x76efc
    type: pointer
    doc: |-
      [Runtime] Pointer to the current leader of the team.

      type: struct entity*
  dungeon_prng_state:
    pos: 0x76f10
    type: prng_state
    doc: |-
      [Runtime] The global PRNG state for dungeon mode, not including the current values in the secondary sequences.

      This struct holds state for the primary LCG, as well as the current configuration controlling which LCG to use when generating random numbers. See DungeonRand16Bit for more information on how the dungeon PRNG works.

      type: struct prng_state
  dungeon_prng_state_secondary_values:
    pos: 0x76f24
    type: dungeon_prng_state_secondary_values_array
    doc: |-
      [Runtime] An array of 5 integers corresponding to the last value generated for each secondary LCG sequence.

      Based on the assembly, this appears to be its own global array, separate from DUNGEON_PRNG_STATE.
  loaded_attack_sprite_file_index:
    pos: 0x76f4c
    type: u2
    doc: |-
      [Runtime] The file index of the currently loaded attack sprite.

      type: uint16_t
  excl_item_effects_weather_atk_speed_boost:
    pos: 0x76f50
    type: excl_item_effects_weather_atk_speed_boost_array
    doc: Array of IDs for exclusive item effects that increase attack speed with
      certain weather conditions.
  excl_item_effects_weather_move_speed_boost:
    pos: 0x76f58
    type: excl_item_effects_weather_move_speed_boost_array
    doc: Array of IDs for exclusive item effects that increase movement speed 
      with certain weather conditions.
  excl_item_effects_weather_no_status:
    pos: 0x76f60
    type: excl_item_effects_weather_no_status_array
    doc: Array of IDs for exclusive item effects that grant status immunity with
      certain weather conditions.
  ai_thrown_item_action_choice_count:
    pos: 0x7709c
    type: u4
    doc: '[Runtime] Used to store the number of positions output by GetPossibleAiArcItemTargets
      and the number of directions/probabilities output by GetPossibleAiThrownItemDirections.'
  excl_item_effects_evasion_boost:
    pos: 0x770b0
    type: excl_item_effects_evasion_boost_array
    doc: Array of IDs for exclusive item effects that grant an evasion boost 
      with certain weather conditions.
  default_tile:
    pos: 0x770bc
    type: tile
    doc: |-
      The default tile struct.

      This is just a struct full of zeroes, but is used as a fallback in various places where a "default" tile is needed, such as when a grid index is out of range.

      type: struct tile
  hidden_stairs_spawn_blocked:
    pos: 0x77124
    type: u1
    doc: |-
      [Runtime] A flag for when Hidden Stairs could normally have spawned on the floor but didn't.

      This is set either when the Hidden Stairs just happen not to spawn by chance, or when the current floor is a rescue or mission destination floor.

      This appears to be part of a larger (8-byte?) struct. It seems like this value is at least followed by 3 bytes of padding and a 4-byte integer field.
  fixed_room_data_ptr:
    pos: 0x7712c
    type: pointer
    doc: '[Runtime] Pointer to decoded fixed room data loaded from the BALANCE/fixed.bin
      file.'
  dungeon_fades_ptr:
    pos: 0x77178
    type: pointer
    doc: '[Runtime] Pointer to the dungeon fades struct that maintains the status
      of screen fades in dungeon mode.'
