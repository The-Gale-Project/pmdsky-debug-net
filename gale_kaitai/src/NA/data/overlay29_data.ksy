meta:
  id: overlay29_data
  endian: le
instances:
  spawn_rand_max:
    pos: 0xbc10
    doc: Equal to 10,000 (0x2710). Used as parameter for DungeonRandInt to generate
      the random number which determines the entity to spawn.
    type: s4
  dungeon_prng_lcg_increment_secondary:
    pos: 0xe854
    doc: The increment for the dungeon PRNG's secondary LCGs, 2531011 (0x269EC3).
      This happens to be the same increment that the Microsoft Visual C++ runtime
      library uses in its implementation of the rand() function.
    type: u4
  attack_sprite_buffer_size:
    pos: 0x1ac98
    doc: Size of the buffer used to store the current attack sprite file.
    type: s4
  kecleon_female_id:
    pos: 0x1b1c4
    doc: 0x3D7 (983). Used when spawning Kecleon on an even numbered floor.
    size: 0x4
  kecleon_male_id:
    pos: 0x1b1c8
    doc: 0x17F (383). Used when spawning Kecleon on an odd numbered floor.
    size: 0x4
  msg_id_slow_start:
    pos: 0x1d090
    doc: ID of the message printed when a monster has the ability Slow Start at the
      beginning of the floor.
    type: s4
  experience_point_gain_cap:
    pos: 0x26488
    doc: A cap on the experience that can be given to a monster in one call to AddExpSpecial
    type: s4
  judgment_move_id:
    pos: 0x30218
    doc: |-
      Move ID for Judgment (0x1D3)

      type: enum move_id
    size: 0x4
  regular_attack_move_id:
    pos: 0x3021c
    doc: |-
      Move ID for the regular attack (0x163)

      type: enum move_id
    size: 0x4
  deoxys_attack_id:
    pos: 0x30220
    doc: |-
      Monster ID for Deoxys in Attack Forme (0x1A3)

      type: enum monster_id
    size: 0x4
  deoxys_speed_id:
    pos: 0x30224
    doc: |-
      Monster ID for Deoxys in Speed Forme (0x1A5)

      type: enum monster_id
    size: 0x4
  giratina_altered_id:
    pos: 0x30228
    doc: |-
      Monster ID for Giratina in Altered Forme (0x211)

      type: enum monster_id
    size: 0x4
  punishment_move_id:
    pos: 0x3022c
    doc: |-
      Move ID for Punishment (0x1BD)

      type: enum move_id
    size: 0x4
  offense_stat_max:
    pos: 0x3025c
    doc: Cap on an attacker's modified offense (attack or special attack) stat after
      boosts. Used during damage calculation.
    type: s4
  belly_lost_per_turn:
    pos: 0x34830
    doc: |-
      The base value by which belly is decreased every turn.

      Its raw value is 0x199A, which encodes a binary fixed-point number (16 fraction bits) with value (0x199A * 2^-16), and is the closest approximation to 0.1 representable in this number format.
    type: s4
  monster_heal_hp_max:
    pos: 0x390a0
    doc: The maximum amount of HP a monster can have (999).
    type: s4
  move_target_and_range_special_user_healing:
    pos: 0x3eaf4
    doc: |-
      The move target and range code for special healing moves that target just the user (0x273).

      type: struct move_target_and_range (+ padding)
    size: 0x4
  plain_seed_string_id:
    pos: 0x40508
    doc: The string ID for eating a Plain Seed (0xBE9).
    type: s4
  max_elixir_pp_restoration:
    pos: 0x4050c
    doc: The amount of PP restored per move by ingesting a Max Elixir (0x3E7).
    type: s4
  slip_seed_fail_string_id:
    pos: 0x4096c
    doc: The string ID for when eating the Slip Seed fails (0xC75).
    type: s4
  rock_wrecker_move_id:
    pos: 0x48360
    doc: The move ID for Rock Wrecker (453).
    size: 0x4
  castform_normal_form_male_id:
    pos: 0x591f8
    doc: Castform's male normal form ID (0x17B)
    size: 0x4
  castform_normal_form_female_id:
    pos: 0x591fc
    doc: Castform's female normal form ID (0x3D3)
    size: 0x4
  cherrim_sunshine_form_male_id:
    pos: 0x59200
    doc: Cherrim's male sunshine form ID (0x1CD)
    size: 0x4
  cherrim_overcast_form_female_id:
    pos: 0x59204
    doc: Cherrim's female overcast form ID (0x424)
    size: 0x4
  cherrim_sunshine_form_female_id:
    pos: 0x59208
    doc: Cherrim's female sunshine form ID (0x425)
    size: 0x4
  default_max_position:
    pos: 0x63d58
    doc: A large number (9999) to use as a default position for keeping track of min/max
      position values
    type: s4
  fixed_room_tile_spawn_table:
    pos: 0x73b90
    doc: |-
      Table of tiles that can spawn in fixed rooms, pointed into by the FIXED_ROOM_TILE_SPAWN_TABLE.

      This is an array of 11 4-byte entries containing info about one tile each. Info includes the trap ID if a trap, room ID, and flags.

      type: struct fixed_room_tile_spawn_entry[11]
    size: 0x2c
  treasure_box_1_item_ids:
    pos: 0x73bbc
    doc: |-
      Item IDs for variant 1 of each of the treasure box items (ITEM_*_BOX_1).

      type: struct item_id_16[12]
    size: 0x18
  fixed_room_revisit_overrides:
    pos: 0x73bd4
    doc: |-
      Table of fixed room IDs, which if nonzero, overrides the normal fixed room ID for a floor (which is used to index the table) if the dungeon has already been cleared previously.

      Overrides are used to substitute different fixed room data for things like revisits to story dungeons.

      type: struct fixed_room_id_8[256]
    size: 0x100
  fixed_room_monster_spawn_table:
    pos: 0x73cd4
    doc: |-
      Table of monsters that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.

      This is an array of 120 4-byte entries containing info about one monster each. Info includes the monster ID, stats, and behavior type.

      type: struct fixed_room_monster_spawn_entry[120]
    size: 0x1e0
  fixed_room_item_spawn_table:
    pos: 0x73eb4
    doc: |-
      Table of items that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.

      This is an array of 63 8-byte entries containing one item ID each.

      type: struct fixed_room_item_spawn_entry[63]
    size: 0x1f8
  fixed_room_entity_spawn_table:
    pos: 0x740ac
    doc: |-
      Table of entities (items, monsters, tiles) that can spawn in fixed rooms, which is indexed into by the main data structure for each fixed room.

      This is an array of 269 entries. Each entry contains 3 pointers (one into FIXED_ROOM_ITEM_SPAWN_TABLE, one into FIXED_ROOM_MONSTER_SPAWN_TABLE, and one into FIXED_ROOM_TILE_SPAWN_TABLE), and represents the entities that can spawn on one specific tile in a fixed room.

      type: struct fixed_room_entity_spawn_entry[269]
    size: 0xc9c
  status_icon_array_muzzled:
    pos: 0x74f7c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::muzzled
      * 8. See UpdateStatusIconFlags for details.
    size: 0x10
  status_icon_array_magnet_rise:
    pos: 0x74f8c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::magnet_rise
      * 8. See UpdateStatusIconFlags for details.
    size: 0x10
  status_icon_array_miracle_eye:
    pos: 0x74fac
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::miracle_eye
      * 8. See UpdateStatusIconFlags for details.
    size: 0x18
  status_icon_array_leech_seed:
    pos: 0x74fbc
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::leech_seed
      * 8. See UpdateStatusIconFlags for details.
    size: 0x18
  status_icon_array_long_toss:
    pos: 0x74fd4
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::long_toss
      * 8. See UpdateStatusIconFlags for details.
    size: 0x18
  status_icon_array_blinded:
    pos: 0x7502c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::blinded
      * 8. See UpdateStatusIconFlags for details.
    size: 0x28
  status_icon_array_burn:
    pos: 0x75054
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::burn
      * 8. See UpdateStatusIconFlags for details.
    size: 0x28
  status_icon_array_sure_shot:
    pos: 0x7507c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::sure_shot
      * 8. See UpdateStatusIconFlags for details.
    size: 0x28
  status_icon_array_invisible:
    pos: 0x750a4
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::invisible
      * 8. See UpdateStatusIconFlags for details.
    size: 0x28
  status_icon_array_sleep:
    pos: 0x750cc
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::sleep
      * 8. See UpdateStatusIconFlags for details.
    size: 0x40
  status_icon_array_curse:
    pos: 0x750fc
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::curse
      * 8. See UpdateStatusIconFlags for details.
    size: 0x38
  status_icon_array_freeze:
    pos: 0x75134
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::freeze
      * 8. See UpdateStatusIconFlags for details.
    size: 0x40
  status_icon_array_cringe:
    pos: 0x75174
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::cringe
      * 8. See UpdateStatusIconFlags for details.
    size: 0x40
  status_icon_array_bide:
    pos: 0x751b4
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::bide
      * 8. See UpdateStatusIconFlags for details.
    size: 0x70
  status_icon_array_reflect:
    pos: 0x752b4
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::reflect
      * 8. See UpdateStatusIconFlags for details.
    size: 0x90
  directions_xy:
    pos: 0x754dc
    doc: |-
      An array mapping each direction index to its x and y displacements.

      Directions start with 0=down and proceed counterclockwise (see enum direction_id). Displacements for x and y are interleaved and encoded as 2-byte signed integers. For example, the first two integers are [0, 1], which correspond to the x and y displacements for the "down" direction (positive y means down).
    type: s2
    repeat: expr
    repeat-expr: 8
  displacements_within_2_largest_first:
    pos: 0x7559c
    doc: |-
      An array of displacement vectors with max norm <= 2, ordered in descending order by norm.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[26]
    size: 0x68
  displacements_within_2_smallest_first:
    pos: 0x75604
    doc: |-
      An array of displacement vectors with max norm <= 2, ordered in ascending order by norm.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[26]
    size: 0x68
  displacements_within_3:
    pos: 0x7566c
    doc: |-
      An array of displacement vectors with max norm <= 3. The elements are vaguely in ascending order by norm, but not exactly.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[50]
    size: 0xc8
  item_category_actions:
    pos: 0x75dd0
    doc: |-
      Action ID associated with each item category. Used by GetItemAction.

      Each entry is 2 bytes long.
    size: 0x20
  fractional_turn_sequence:
    pos: 0x76044
    doc: |-
      Read by certain functions that are called by RunFractionalTurn to see if they should be executed.

      Array is accessed via a pointer added to some multiple of fractional_turn, so that if the resulting memory location is zero, the function returns.
    type: s2
    repeat: expr
    repeat-expr: 125
  belly_drain_in_walls_int:
    pos: 0x76528
    doc: The additional amount by which belly is decreased every turn when inside
      walls (integer part)
    type: u2
  belly_drain_in_walls_thousandths:
    pos: 0x7652a
    doc: The additional amount by which belly is decreased every turn when inside
      walls (fractional thousandths)
    type: u2
  monster_treatment_data:
    pos: 0x76560
    doc: |-
      A 4D array of monster_treatment enum values. Used by GetTreatmentBetweenMonsters to determine treatment based on several parameters.
      The parameters are (in order of how the array is indexed):
      1. Value from 0-3 based on entity1's decoy_ai_tracker value.
        If decoy_ai_tracker is 0 and the entity is the leader, this value is 0. Otherwise it is decoy_ai_tracker + 1
      2. Boolean value for whether entity1 is a wild Pokémon.
      3. Boolean value for whether entity2 is a wild Pokémon.
      4. Boolean value for whether entity2 is a decoy.
    size: 0x20
  damage_multiplier_0_5:
    pos: 0x765fc
    doc: A generic damage multiplier of 0.5 used in various places, as a 64-bit fixed-point
      number with 16 fraction bits.
    size: 0x8
  damage_multiplier_1_5:
    pos: 0x76604
    doc: A generic damage multiplier of 1.5 used in various places, as a 64-bit fixed-point
      number with 16 fraction bits.
    size: 0x8
  damage_multiplier_2:
    pos: 0x7660c
    doc: A generic damage multiplier of 2 used in various places, as a 64-bit fixed-point
      number with 16 fraction bits.
    size: 0x8
  cloudy_damage_multiplier:
    pos: 0x7661c
    doc: The extra damage multiplier for non-Normal-type moves when the weather is
      Cloudy, as a 64-bit fixed-point number with 16 fraction bits (0.75).
    size: 0x8
  solid_rock_multiplier:
    pos: 0x76624
    doc: The extra damage multiplier for super-effective moves when Solid Rock or
      Filter is active, as a 64-bit fixed-point number with 16 fraction bits (0.75).
    size: 0x8
  damage_formula_max_base:
    pos: 0x7662c
    doc: The maximum value of the base damage formula (after DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER
      application, if relevant), as a 64-bit binary fixed-point number with 16 fraction
      bits (999).
    size: 0x8
  wonder_guard_multiplier:
    pos: 0x76634
    doc: The damage multiplier for moves affected by Wonder Guard, as a 64-bit fixed-point
      number with 16 fraction bits (0).
    size: 0x8
  damage_formula_min_base:
    pos: 0x7663c
    doc: The minimum value of the base damage formula (after DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER
      application, if relevant), as a 64-bit binary fixed-point number with 16 fraction
      bits (1).
    size: 0x8
  type_damage_negating_exclusive_item_effects:
    pos: 0x76664
    doc: |-
      List of exclusive item effects that negate damage of a certain type, terminated by a TYPE_NEUTRAL entry.

      type: struct damage_negating_exclusive_eff_entry[28]
    size: 0xe0
  two_turn_statuses:
    pos: 0x76820
    doc: Lists all status IDs that are for two-turn moves. The last entry is null.
    size: 0xb
  two_turn_moves_and_statuses:
    pos: 0x7686c
    doc: List that matches two-turn move IDs to their corresponding status ID. The
      last entry is null.
    size: 0x2c
  spatk_stat_idx:
    pos: 0x768a8
    doc: The index (1) of the special attack entry in internal stat structs, such
      as the stat modifier array for a monster.
    type: s4
  atk_stat_idx:
    pos: 0x768ac
    doc: The index (0) of the attack entry in internal stat structs, such as the stat
      modifier array for a monster.
    type: s4
  rollout_damage_mult_table:
    pos: 0x768b0
    doc: |-
      A table of damage multipliers for each successive hit of Rollout/Ice Ball. Each entry is a binary fixed-point number with 8 fraction bits.

      type: int32_t[10]
    type: s4
    repeat: expr
    repeat-expr: 10
  map_color_table:
    pos: 0x76d90
    doc: |-
      In order: white, black, red, green, blue, magenta, dark pink, chartreuse, light orange

      Note: unverified, ported from Irdkwia's notes

      type: struct rgba[9]
    size: 0x24
  corner_cardinal_neighbor_is_open:
    pos: 0x76dd0
    doc: |-
      An array mapping each (corner index, neighbor direction index) to whether or not that neighbor is expected to be open floor.

      Corners start with 0=top-left and proceed clockwise. Directions are enumerated as with DIRECTIONS_XY. The array is indexed by i=(corner_index * N_DIRECTIONS + direction). An element of 1 (0) means that starting from the specified corner of a room, moving in the specified direction should lead to an open floor tile (non-open terrain like a wall).

      Note that this array is only used for the cardinal directions. The elements at odd indexes are unused and unconditionally set to 0.

      This array is used by the dungeon generation algorithm when generating room imperfections. See GenerateRoomImperfections.
    size: 0x20
  gummi_like_string_ids:
    pos: 0x77090
    doc: List that holds the string IDs for how much a monster liked a gummi in decreasing
      order.
    type: s2
    repeat: expr
    repeat-expr: 4
  gummi_iq_string_ids:
    pos: 0x770e4
    doc: List that holds the string IDs for how much a monster's IQ was raised by
      in decreasing order.
    type: s2
    repeat: expr
    repeat-expr: 5
  damage_string_ids:
    pos: 0x770f0
    doc: List that matches the damage_message ID to their corresponding string ID.
      The null entry at 0xE in the middle is for hunger. The last entry is null.
    type: s2
    repeat: expr
    repeat-expr: 27
  dungeon_ptr:
    pos: 0x772f8
    doc: |-
      [Runtime] Pointer to the dungeon struct in dungeon mode.

      This is a "working copy" of DUNGEON_PTR_MASTER. The main dungeon engine uses this pointer (or rather pointers to this pointer) when actually running dungeon mode.

      type: struct dungeon*
    type: u4
  dungeon_ptr_master:
    pos: 0x772fc
    doc: |-
      [Runtime] Pointer to the dungeon struct in dungeon mode.

      This is a "master copy" of the dungeon pointer. The game uses this pointer when doing low-level memory work (allocation, freeing, zeroing). The normal DUNGEON_PTR is used for most other dungeon mode work.

      type: struct dungeon*
    type: u4
  top_screen_status_ptr:
    pos: 0x77314
    doc: |-
      [Runtime] Pointer for struct for handling the status of the top screen in dungeon mode.

      type: struct top_screen_status
    type: u4
  leader_ptr:
    pos: 0x7731c
    doc: |-
      [Runtime] Pointer to the current leader of the team.

      type: struct entity*
    type: u4
  dungeon_prng_state:
    pos: 0x77330
    doc: |-
      [Runtime] The global PRNG state for dungeon mode, not including the current values in the secondary sequences.

      This struct holds state for the primary LCG, as well as the current configuration controlling which LCG to use when generating random numbers. See DungeonRand16Bit for more information on how the dungeon PRNG works.

      type: struct prng_state
    size: 0x14
  dungeon_prng_state_secondary_values:
    pos: 0x77344
    doc: |-
      [Runtime] An array of 5 integers corresponding to the last value generated for each secondary LCG sequence.

      Based on the assembly, this appears to be its own global array, separate from DUNGEON_PRNG_STATE.
    type: u4
    repeat: expr
    repeat-expr: 5
  loaded_attack_sprite_file_index:
    pos: 0x7736c
    doc: |-
      [Runtime] The file index of the currently loaded attack sprite.

      type: uint16_t
    type: u2
  excl_item_effects_weather_atk_speed_boost:
    pos: 0x77370
    doc: Array of IDs for exclusive item effects that increase attack speed with certain
      weather conditions.
    size: 0x8
  excl_item_effects_weather_move_speed_boost:
    pos: 0x77378
    doc: Array of IDs for exclusive item effects that increase movement speed with
      certain weather conditions.
    size: 0x8
  excl_item_effects_weather_no_status:
    pos: 0x77380
    doc: Array of IDs for exclusive item effects that grant status immunity with certain
      weather conditions.
    size: 0x8
  ai_thrown_item_action_choice_count:
    pos: 0x774bc
    doc: '[Runtime] Used to store the number of positions output by GetPossibleAiArcItemTargets
      and the number of directions/probabilities output by GetPossibleAiThrownItemDirections.'
    type: u4
  excl_item_effects_evasion_boost:
    pos: 0x774d0
    doc: Array of IDs for exclusive item effects that grant an evasion boost with
      certain weather conditions.
    size: 0x8
  default_tile:
    pos: 0x774e4
    doc: |-
      The default tile struct.

      This is just a struct full of zeroes, but is used as a fallback in various places where a "default" tile is needed, such as when a grid index is out of range.

      type: struct tile
    size: 0x14
  hidden_stairs_spawn_blocked:
    pos: 0x7754c
    doc: |-
      [Runtime] A flag for when Hidden Stairs could normally have spawned on the floor but didn't.

      This is set either when the Hidden Stairs just happen not to spawn by chance, or when the current floor is a rescue or mission destination floor.

      This appears to be part of a larger (8-byte?) struct. It seems like this value is at least followed by 3 bytes of padding and a 4-byte integer field.
    size: 0x1
  fixed_room_data_ptr:
    pos: 0x77554
    doc: '[Runtime] Pointer to decoded fixed room data loaded from the BALANCE/fixed.bin
      file.'
    type: u4
  dungeon_fades_ptr:
    pos: 0x775a0
    doc: '[Runtime] Pointer to the dungeon fades struct that maintains the status
      of screen fades in dungeon mode.'
    type: u4
types: {}
enums: {}
