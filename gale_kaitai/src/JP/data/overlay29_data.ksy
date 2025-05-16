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
    size: 0x2c
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
    size: 0x1e0
  fixed_room_item_spawn_table:
    pos: 0x73a94
    doc: |-
      Table of items that can spawn in fixed rooms, pointed into by the FIXED_ROOM_ENTITY_SPAWN_TABLE.

      This is an array of 63 8-byte entries containing one item ID each.

      type: struct fixed_room_item_spawn_entry[63]
    size: 0x1f8
  fixed_room_entity_spawn_table:
    pos: 0x73c8c
    doc: |-
      Table of entities (items, monsters, tiles) that can spawn in fixed rooms, which is indexed into by the main data structure for each fixed room.

      This is an array of 269 entries. Each entry contains 3 pointers (one into FIXED_ROOM_ITEM_SPAWN_TABLE, one into FIXED_ROOM_MONSTER_SPAWN_TABLE, and one into FIXED_ROOM_TILE_SPAWN_TABLE), and represents the entities that can spawn on one specific tile in a fixed room.

      type: struct fixed_room_entity_spawn_entry[269]
    size: 0xc9c
  directions_xy:
    pos: 0x750bc
    doc: |-
      An array mapping each direction index to its x and y displacements.

      Directions start with 0=down and proceed counterclockwise (see enum direction_id). Displacements for x and y are interleaved and encoded as 2-byte signed integers. For example, the first two integers are [0, 1], which correspond to the x and y displacements for the "down" direction (positive y means down).
    type: s2
    repeat: expr
    repeat-expr: 8
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
  two_turn_statuses:
    pos: 0x76400
    doc: Lists all status IDs that are for two-turn moves. The last entry is null.
    size: 0xb
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
types: {}
enums: {}
