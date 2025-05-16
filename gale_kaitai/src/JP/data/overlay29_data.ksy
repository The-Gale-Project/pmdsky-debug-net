meta:
  id: overlay29_data
  endian: le
instances:
  attack_sprite_buffer_size:
    pos: 0x1abc8
    doc: Size of the buffer used to store the current attack sprite file.
    type: s4
  kecleon_female_id:
    pos: 0x1b0ec
    doc: 0x3D7 (983). Used when spawning Kecleon on an even numbered floor.
    size: 0x4
  kecleon_male_id:
    pos: 0x1b0f0
    doc: 0x17F (383). Used when spawning Kecleon on an odd numbered floor.
    size: 0x4
  judgment_move_id:
    pos: 0x300c8
    doc: |-
      Move ID for Judgment (0x1D3)

      type: enum move_id
    size: 0x4
  regular_attack_move_id:
    pos: 0x300cc
    doc: |-
      Move ID for the regular attack (0x163)

      type: enum move_id
    size: 0x4
  deoxys_attack_id:
    pos: 0x300d0
    doc: |-
      Monster ID for Deoxys in Attack Forme (0x1A3)

      type: enum monster_id
    size: 0x4
  deoxys_speed_id:
    pos: 0x300d4
    doc: |-
      Monster ID for Deoxys in Speed Forme (0x1A5)

      type: enum monster_id
    size: 0x4
  giratina_altered_id:
    pos: 0x300d8
    doc: |-
      Monster ID for Giratina in Altered Forme (0x211)

      type: enum monster_id
    size: 0x4
  punishment_move_id:
    pos: 0x300dc
    doc: |-
      Move ID for Punishment (0x1BD)

      type: enum move_id
    size: 0x4
  belly_lost_per_turn:
    pos: 0x346b8
    doc: |-
      The base value by which belly is decreased every turn.

      Its raw value is 0x199A, which encodes a binary fixed-point number (16 fraction bits) with value (0x199A * 2^-16), and is the closest approximation to 0.1 representable in this number format.
    type: s4
  castform_normal_form_male_id:
    pos: 0x58f44
    doc: Castform's male normal form ID (0x17B)
    size: 0x4
  castform_normal_form_female_id:
    pos: 0x58f48
    doc: Castform's female normal form ID (0x3D3)
    size: 0x4
  cherrim_sunshine_form_male_id:
    pos: 0x58f4c
    doc: Cherrim's male sunshine form ID (0x1CD)
    size: 0x4
  cherrim_overcast_form_female_id:
    pos: 0x58f50
    doc: Cherrim's female overcast form ID (0x424)
    size: 0x4
  cherrim_sunshine_form_female_id:
    pos: 0x58f54
    doc: Cherrim's female sunshine form ID (0x425)
    size: 0x4
  fixed_room_tile_spawn_table:
    pos: 0x73770
    doc: |-
      Table of tiles that can spawn in fixed rooms, pointed into by the FIXED_ROOM_TILE_SPAWN_TABLE.

      This is an array of 11 4-byte entries containing info about one tile each. Info includes the trap ID if a trap, room ID, and flags.

      type: struct fixed_room_tile_spawn_entry[11]
    type: fixed_room_tile_spawn_entry
    repeat: expr
    repeat-expr: 11
  treasure_box_1_item_ids:
    pos: 0x7379c
    doc: |-
      Item IDs for variant 1 of each of the treasure box items (ITEM_*_BOX_1).

      type: struct item_id_16[12]
    size: 0x18
  fixed_room_revisit_overrides:
    pos: 0x737b4
    doc: |-
      Table of fixed room IDs, which if nonzero, overrides the normal fixed room ID for a floor (which is used to index the table) if the dungeon has already been cleared previously.

      Overrides are used to substitute different fixed room data for things like revisits to story dungeons.

      type: struct fixed_room_id_8[256]
    size: 0x100
  fixed_room_monster_spawn_table:
    pos: 0x738b4
    doc: |-
      Table of monsters that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.

      This is an array of 120 4-byte entries containing info about one monster each. Info includes the monster ID, stats, and behavior type.

      type: struct fixed_room_monster_spawn_entry[120]
    type: fixed_room_monster_spawn_entry
    repeat: expr
    repeat-expr: 120
  fixed_room_item_spawn_table:
    pos: 0x73a94
    doc: |-
      Table of items that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.

      This is an array of 63 8-byte entries containing one item ID each.

      type: struct fixed_room_item_spawn_entry[63]
    type: fixed_room_item_spawn_entry
    repeat: expr
    repeat-expr: 63
  fixed_room_entity_spawn_table:
    pos: 0x73c8c
    doc: |-
      Table of entities (items, monsters, tiles) that can spawn in fixed rooms, which is indexed into by the main data structure for each fixed room.

      This is an array of 269 entries. Each entry contains 3 pointers (one into FIXED_ROOM_ITEM_SPAWN_TABLE, one into FIXED_ROOM_MONSTER_SPAWN_TABLE, and one into FIXED_ROOM_TILE_SPAWN_TABLE), and represents the entities that can spawn on one specific tile in a fixed room.

      type: struct fixed_room_entity_spawn_entry[269]
    type: fixed_room_entity_spawn_entry
    repeat: expr
    repeat-expr: 269
  status_icon_array_muzzled:
    pos: 0x74b5c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::muzzled
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 2
  status_icon_array_magnet_rise:
    pos: 0x74b6c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::magnet_rise
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 2
  status_icon_array_miracle_eye:
    pos: 0x74b8c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::miracle_eye
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 3
  status_icon_array_leech_seed:
    pos: 0x74b9c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::leech_seed
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 3
  status_icon_array_long_toss:
    pos: 0x74bb4
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::long_toss
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 3
  status_icon_array_blinded:
    pos: 0x74c0c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::blinded
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 5
  status_icon_array_burn:
    pos: 0x74c34
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::burn
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 5
  status_icon_array_sure_shot:
    pos: 0x74c5c
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::sure_shot
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 5
  status_icon_array_invisible:
    pos: 0x74c84
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::invisible
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 5
  status_icon_array_sleep:
    pos: 0x74cac
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::sleep
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 8
  status_icon_array_curse:
    pos: 0x74cdc
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::curse
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 7
  status_icon_array_freeze:
    pos: 0x74d14
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::freeze
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 8
  status_icon_array_cringe:
    pos: 0x74d54
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::cringe
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 8
  status_icon_array_bide:
    pos: 0x74d94
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::bide
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 14
  status_icon_array_reflect:
    pos: 0x74e94
    doc: Array of bit masks used to set monster::status_icon. Indexed by monster::statuses::reflect
      * 8. See UpdateStatusIconFlags for details.
    type: status_icon_flags
    repeat: expr
    repeat-expr: 18
  directions_xy:
    pos: 0x750bc
    doc: |-
      An array mapping each direction index to its x and y displacements.

      Directions start with 0=down and proceed counterclockwise (see enum direction_id). Displacements for x and y are interleaved and encoded as 2-byte signed integers. For example, the first two integers are [0, 1], which correspond to the x and y displacements for the "down" direction (positive y means down).
    type: s2
    repeat: expr
    repeat-expr: 8
  displacements_within_2_largest_first:
    pos: 0x7517c
    doc: |-
      An array of displacement vectors with max norm <= 2, ordered in descending order by norm.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[26]
    type: position
    repeat: expr
    repeat-expr: 26
  displacements_within_2_smallest_first:
    pos: 0x751e4
    doc: |-
      An array of displacement vectors with max norm <= 2, ordered in ascending order by norm.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[26]
    type: position
    repeat: expr
    repeat-expr: 26
  displacements_within_3:
    pos: 0x7524c
    doc: |-
      An array of displacement vectors with max norm <= 3. The elements are vaguely in ascending order by norm, but not exactly.

      The last element, (99, 99), is invalid and used as an end marker.

      type: position[50]
    type: position
    repeat: expr
    repeat-expr: 50
  fractional_turn_sequence:
    pos: 0x75c24
    doc: |-
      Read by certain functions that are called by RunFractionalTurn to see if they should be executed.

      Array is accessed via a pointer added to some multiple of fractional_turn, so that if the resulting memory location is zero, the function returns.
    type: s2
    repeat: expr
    repeat-expr: 125
  belly_drain_in_walls_int:
    pos: 0x76108
    doc: The additional amount by which belly is decreased every turn when inside
      walls (integer part)
    type: u2
  belly_drain_in_walls_thousandths:
    pos: 0x7610a
    doc: The additional amount by which belly is decreased every turn when inside
      walls (fractional thousandths)
    type: u2
  monster_treatment_data:
    pos: 0x76140
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
    pos: 0x761dc
    doc: A generic damage multiplier of 0.5 used in various places, as a 64-bit fixed-point
      number with 16 fraction bits.
    type: fx64_16
  damage_multiplier_1_5:
    pos: 0x761e4
    doc: A generic damage multiplier of 1.5 used in various places, as a 64-bit fixed-point
      number with 16 fraction bits.
    type: fx64_16
  damage_multiplier_2:
    pos: 0x761ec
    doc: A generic damage multiplier of 2 used in various places, as a 64-bit fixed-point
      number with 16 fraction bits.
    type: fx64_16
  cloudy_damage_multiplier:
    pos: 0x761fc
    doc: The extra damage multiplier for non-Normal-type moves when the weather is
      Cloudy, as a 64-bit fixed-point number with 16 fraction bits (0.75).
    type: fx64_16
  solid_rock_multiplier:
    pos: 0x76204
    doc: The extra damage multiplier for super-effective moves when Solid Rock or
      Filter is active, as a 64-bit fixed-point number with 16 fraction bits (0.75).
    type: fx64_16
  damage_formula_max_base:
    pos: 0x7620c
    doc: The maximum value of the base damage formula (after DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER
      application, if relevant), as a 64-bit binary fixed-point number with 16 fraction
      bits (999).
    type: fx64_16
  damage_formula_min_base:
    pos: 0x7621c
    doc: The minimum value of the base damage formula (after DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER
      application, if relevant), as a 64-bit binary fixed-point number with 16 fraction
      bits (1).
    type: fx64_16
  type_damage_negating_exclusive_item_effects:
    pos: 0x76244
    doc: |-
      List of exclusive item effects that negate damage of a certain type, terminated by a TYPE_NEUTRAL entry.

      type: struct damage_negating_exclusive_eff_entry[28]
    type: damage_negating_exclusive_eff_entry
    repeat: expr
    repeat-expr: 28
  two_turn_statuses:
    pos: 0x76400
    doc: Lists all status IDs that are for two-turn moves. The last entry is null.
    size: 0xb
  two_turn_moves_and_statuses:
    pos: 0x7644c
    doc: List that matches two-turn move IDs to their corresponding status ID. The
      last entry is null.
    type: two_turn_move_and_status
    repeat: expr
    repeat-expr: 22
  spatk_stat_idx:
    pos: 0x76488
    doc: The index (1) of the special attack entry in internal stat structs, such
      as the stat modifier array for a monster.
    type: s4
  atk_stat_idx:
    pos: 0x7648c
    doc: The index (0) of the attack entry in internal stat structs, such as the stat
      modifier array for a monster.
    type: s4
  rollout_damage_mult_table:
    pos: 0x76490
    doc: |-
      A table of damage multipliers for each successive hit of Rollout/Ice Ball. Each entry is a binary fixed-point number with 8 fraction bits.

      type: int32_t[10]
    type: s4
    repeat: expr
    repeat-expr: 10
  map_color_table:
    pos: 0x76970
    doc: |-
      In order: white, black, red, green, blue, magenta, dark pink, chartreuse, light orange

      Note: unverified, ported from Irdkwia's notes

      type: struct rgba[9]
    type: rgba
    repeat: expr
    repeat-expr: 9
  gummi_like_string_ids:
    pos: 0x76c70
    doc: List that holds the string IDs for how much a monster liked a gummi in decreasing
      order.
    type: s2
    repeat: expr
    repeat-expr: 4
  gummi_iq_string_ids:
    pos: 0x76cc4
    doc: List that holds the string IDs for how much a monster's IQ was raised by
      in decreasing order.
    type: s2
    repeat: expr
    repeat-expr: 5
  damage_string_ids:
    pos: 0x76cd0
    doc: List that matches the damage_message ID to their corresponding string ID.
      The null entry at 0xE in the middle is for hunger. The last entry is null.
    type: s2
    repeat: expr
    repeat-expr: 27
  dungeon_ptr:
    pos: 0x76ed8
    doc: |-
      [Runtime] Pointer to the dungeon struct in dungeon mode.

      This is a "working copy" of DUNGEON_PTR_MASTER. The main dungeon engine uses this pointer (or rather pointers to this pointer) when actually running dungeon mode.

      type: struct dungeon*
    type: u4
  top_screen_status_ptr:
    pos: 0x76ef4
    doc: |-
      [Runtime] Pointer for struct for handling the status of the top screen in dungeon mode.

      type: struct top_screen_status
    type: u4
  leader_ptr:
    pos: 0x76efc
    doc: |-
      [Runtime] Pointer to the current leader of the team.

      type: struct entity*
    type: u4
  dungeon_prng_state:
    pos: 0x76f10
    doc: |-
      [Runtime] The global PRNG state for dungeon mode, not including the current values in the secondary sequences.

      This struct holds state for the primary LCG, as well as the current configuration controlling which LCG to use when generating random numbers. See DungeonRand16Bit for more information on how the dungeon PRNG works.

      type: struct prng_state
    type: prng_state
  dungeon_prng_state_secondary_values:
    pos: 0x76f24
    doc: |-
      [Runtime] An array of 5 integers corresponding to the last value generated for each secondary LCG sequence.

      Based on the assembly, this appears to be its own global array, separate from DUNGEON_PRNG_STATE.
    type: u4
    repeat: expr
    repeat-expr: 5
  loaded_attack_sprite_file_index:
    pos: 0x76f4c
    doc: |-
      [Runtime] The file index of the currently loaded attack sprite.

      type: uint16_t
    type: u2
  ai_thrown_item_action_choice_count:
    pos: 0x7709c
    doc: '[Runtime] Used to store the number of positions output by GetPossibleAiArcItemTargets
      and the number of directions/probabilities output by GetPossibleAiThrownItemDirections.'
    type: u4
  default_tile:
    pos: 0x770bc
    doc: |-
      The default tile struct.

      This is just a struct full of zeroes, but is used as a fallback in various places where a "default" tile is needed, such as when a grid index is out of range.

      type: struct tile
    type: tile
  fixed_room_data_ptr:
    pos: 0x7712c
    doc: '[Runtime] Pointer to decoded fixed room data loaded from the BALANCE/fixed.bin
      file.'
    type: u4
  dungeon_fades_ptr:
    pos: 0x77178
    doc: '[Runtime] Pointer to the dungeon fades struct that maintains the status
      of screen fades in dungeon mode.'
    type: u4
types:
  move_target_and_range: []
  fixed_room_tile_spawn_entry:
  - id: id
    type: trap_id_8
  - id: flags
    type: u1
  - id: room
    type: u1
  fixed_room_monster_spawn_entry:
  - id: id
    type: monster_id_16
  - id: stat_table_idx
    type: u1
  - id: behavior
    type: monster_behavior_8
  fixed_room_item_spawn_entry:
  - id: item
    type: bulk_item
  - id: field_0x4
    type: u1
  - id: field_0x5
    type: u1
  - id: field_0x6
    type: u1
  - id: field_0x7
    type: u1
  fixed_room_entity_spawn_entry: []
  status_icon_flags:
  - id: field_0x5
    type: u1
  - id: field_0x6
    type: u1
  - id: field_0x7
    type: u1
  position:
  - id: x
    type: s2
  - id: y
    type: s2
  fx64_16:
  - id: upper
    type: s4
  - id: lower
    type: u4
  damage_negating_exclusive_eff_entry:
  - id: type
    type: type_id
  - id: effect
    type: exclusive_item_effect_id
  two_turn_move_and_status:
  - id: move
    type: move_id_16
  - id: status
    type: status_two_turn_id_16
  rgba:
  - id: r
    type: u1
  - id: g
    type: u1
  - id: b
    type: u1
  - id: a
    type: u1
  prng_state:
  - id: use_secondary
    type: s4
  - id: seq_num_primary
    type: u4
  - id: preseed
    type: u4
  - id: last_value_primary
    type: u4
  - id: idx_secondary
    type: s4
  tile:
  - id: spawn_or_visibility_flags
    type: spawn_or_visibility_flags
  - id: texture_id
    type: u2
  - id: field_0x6
    type: u1
  - id: room
    type: u1
enums: {}
