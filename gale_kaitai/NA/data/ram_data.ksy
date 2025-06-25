meta:
  id: ram_data
  endian: le
  imports:
  - ../types/default_memory_arena_memory_array
  - ../types/mem_arena
  - ../types/ground_memory_arena_2_blocks_array
  - ../types/ground_memory_arena_2_memory_array
  - ../types/pointer
  - ../types/dungeon
  - ../types/move_data_table
  - ../types/mem_arena
  - ../types/sound_memory_arena_blocks_array
  - ../types/sound_memory_arena_memory_array
  - ../types/touchscreen_status
  - ../types/bag_items_array
  - ../types/pointer
  - ../types/storage_items_array
  - ../types/storage_item_quantities_array
  - ../types/pointer
  - ../types/kecleon_shop_items_array
  - ../types/unused_kecleon_shop_items_array
  - ../types/pointer
  - ../types/kecleon_wares_items_array
  - ../types/unused_kecleon_wares_items_array
  - ../types/audio_commands_buffer_array
  - ../types/pointer
  - ../types/window_list
  - ../types/pointer
  - ../types/pointer
  - ../types/pointer
  - ../types/move
  - ../types/script_var_value_table
  - ../types/special_episode_type_8
  - ../types/file_stream
  - ../types/dungeon_id_8
  - ../types/team_name_array
  - ../types/monster_id_16
  - ../types/level_up_data_decompress_buffer_array
  - ../types/team_member_table
  - ../types/vram_banks_set
  - ../types/thread_info
  - ../types/pointer
  - ../types/pointer
  - ../types/lock_notify_array_array
  - ../types/mem_arena
  - ../types/ground_memory_arena_1_blocks_array
  - ../types/ground_memory_arena_1_memory_array
  - ../types/sentry_duty
  - ../types/pointer
  - ../types/mobility_type_to_dungeon_mobility_type_array
  - ../types/ai_thrown_item_direction_is_used_array
  - ../types/ai_thrown_item_probabilities_array
  - ../types/ai_thrown_item_directions_array
  - ../types/ai_can_attack_in_direction_array
  - ../types/ai_potential_attack_target_directions_array
  - ../types/ai_potential_attack_target_weights_array
  - ../types/ai_potential_attack_targets_array
  - ../types/floor_generation_status
instances:
  default_memory_arena_memory:
    pos: 0xb4bc0
    type: default_memory_arena_memory_array
    doc: |-
      The memory region for the default memory arena.

      The length is defined by DEFAULT_MEMORY_ARENA_SIZE.

      One mode that uses this region for heap allocations is dungeon mode.
  ground_memory_arena_2:
    pos: 0x145a08
    type: mem_arena
    doc: |-
      This is a memory subarena under DEFAULT_MEMORY_ARENA used for some things in ground mode.

      It's used for user_flags 14.

      Including the allocator metadata, this arena occupies 0xB0000 bytes of space.

      type: struct mem_arena
  ground_memory_arena_2_blocks:
    pos: 0x145a24
    type: ground_memory_arena_2_blocks_array
    doc: |-
      The block array for GROUND_MEMORY_ARENA_2.

      type: struct mem_block[32]
  ground_memory_arena_2_memory:
    pos: 0x145d24
    type: ground_memory_arena_2_memory_array
    doc: The memory region for GROUND_MEMORY_ARENA_2.
  dungeon_colormap_ptr:
    pos: 0x1b9cf4
    type: pointer
    doc: |-
      Pointer to a colormap used to render colors in a dungeon.

      The colormap is a list of 4-byte RGB colors of the form {R, G, B, padding}, which the game indexes into when rendering colors. Some weather conditions modify the colormap, which is how the color scheme changes when it's, e.g., raining.
  dungeon_struct:
    pos: 0x1b9d34
    type: dungeon
    doc: |-
      The dungeon context struct used for tons of stuff in dungeon mode. See struct dungeon in the C headers.

      This struct never seems to be referenced directly, and is instead usually accessed via DUNGEON_PTR in overlay 29.

      type: struct dungeon
  move_data_table:
    pos: 0x2113cc
    type: move_data_table
    doc: |-
      The move data table loaded directly from /BALANCE/waza_p.bin. See struct move_data_table in the C headers.

      Pointed to by MOVE_DATA_TABLE_PTR in the ARM 9 binary.

      type: struct move_data_table
  sound_memory_arena:
    pos: 0x24efa0
    type: mem_arena
    doc: |-
      This is a memory subarena under DEFAULT_MEMORY_ARENA that seems to be used exclusively for sound data.

      Including allocator metadata, this subarena occupies 0x3C000 bytes of space within the default arena.

      It's referenced by various sound functions like LoadDseFile, PlaySeLoad, and PlayBgm when allocating memory.

      type: struct mem_arena
  sound_memory_arena_blocks:
    pos: 0x24efbc
    type: sound_memory_arena_blocks_array
    doc: |-
      The block array for SOUND_MEMORY_ARENA.

      type: struct mem_block[20]
  sound_memory_arena_memory:
    pos: 0x24f19c
    type: sound_memory_arena_memory_array
    doc: |-
      The memory region for SOUND_MEMORY_ARENA.

      This region appears to be used for sound-related heap allocations, like when loading sound files into memory.
  frames_since_launch_0:
    pos: 0x2a354c
    type: u4
    doc: Starts at 0 when the game is first launched, and continuously ticks up 
      once per frame while the game is running.
  frames_since_launch_1:
    pos: 0x2a359c
    type: u4
    doc: Starts at 0 when the game is first launched, and continuously ticks up 
      once per frame while the game is running.
  touchscreen_status:
    pos: 0x2a35dc
    type: touchscreen_status
    doc: Status of the touchscreen, including the coordinates of the currently 
      pressed position in pixels.
  bag_items:
    pos: 0x2a3824
    type: bag_items_array
    doc: |-
      Array of item structs within the player's bag.

      While the game only allows a maximum of 48 items during normal play, it seems to read up to 50 item slots if filled.

      type: struct item[50]
  bag_items_ptr:
    pos: 0x2a3ba8
    type: pointer
    doc: Pointer to BAG_ITEMS.
  storage_items:
    pos: 0x2a3bae
    type: storage_items_array
    doc: |-
      Array of item IDs in the player's item storage.

      For stackable items, the quantities are stored elsewhere, in STORAGE_ITEM_QUANTITIES.

      type: struct item_id_16[1000]
  storage_item_quantities:
    pos: 0x2a437e
    type: storage_item_quantities_array
    doc: |-
      Array of 1000 2-byte (unsigned) quantities corresponding to the item IDs in STORAGE_ITEMS.

      If the corresponding item ID is not a stackable item, the entry in this array is unused, and will be 0.
  kecleon_shop_items_ptr:
    pos: 0x2a4b50
    type: pointer
    doc: Pointer to KECLEON_SHOP_ITEMS.
  kecleon_shop_items:
    pos: 0x2a4b54
    type: kecleon_shop_items_array
    doc: |-
      Array of up to 8 items in the Kecleon Shop.

      If there are fewer than 8 items, the array is expected to be null-terminated.

      type: struct bulk_item[8]
  unused_kecleon_shop_items:
    pos: 0x2a4b74
    type: unused_kecleon_shop_items_array
    doc: Seems to be another array like KECLEON_SHOP_ITEMS, but don't actually 
      appear to be used by the Kecleon Shop.
  kecleon_wares_items_ptr:
    pos: 0x2a4b94
    type: pointer
    doc: Pointer to KECLEON_WARES_ITEMS.
  kecleon_wares_items:
    pos: 0x2a4b98
    type: kecleon_wares_items_array
    doc: |-
      Array of up to 4 items in Kecleon Wares.

      If there are fewer than 4 items, the array is expected to be null-terminated.

      type: struct bulk_item[4]
  unused_kecleon_wares_items:
    pos: 0x2a4ba8
    type: unused_kecleon_wares_items_array
    doc: Seems to be another array like KECLEON_WARES_ITEMS, but don't actually 
      appear to be used by Kecleon Wares.
  money_carried:
    pos: 0x2a4bb8
    type: s4
    doc: The amount of money the player is currently carrying.
  money_stored:
    pos: 0x2a4bc4
    type: s4
    doc: The amount of money the player currently has stored in the Duskull 
      Bank.
  audio_commands_buffer:
    pos: 0x2a4c50
    type: audio_commands_buffer_array
    doc: Buffer used to store audio commands. 16 entries in total. Seems like 
      entries are removed at some point (maybe after the commands are read or 
      after they finish executing).
  sound_memory_arena_ptr:
    pos: 0x2a4e54
    type: pointer
    doc: Pointer to SOUND_MEMORY_ARENA.
  window_list:
    pos: 0x2a88dc
    type: window_list
    doc: |-
      Array of all window structs. Newly created window structs are taken from slots in this array.

      Note that this array isn't strictly ordered in any way. A newly created window will occupy the first available slot. If a window in an early slot is destroyed, windows that are still active in later slots won't be shifted back unless destroyed and recreated.

      type: struct window_list
  cursor_16_sprite_id:
    pos: 0x2aac64
    type: u2
    doc: Id of the "FONT/cursor_16.wan" sprite loaded in WAN_TABLE
  cursor_animation_control:
    pos: 0x2aac80
    type: pointer
    doc: animation_control of "FONT/cursor.wan"
  cursor_16_animation_control:
    pos: 0x2aacfc
    type: pointer
    doc: animation_control of "FONT/cursor_16.wan"
  alert_sprite_id:
    pos: 0x2aad78
    type: u2
    doc: Id of the "FONT/alert.wan" sprite loaded in WAN_TABLE
  alert_animation_control:
    pos: 0x2aad7c
    type: pointer
    doc: animation_control of "FONT/alter.wan"
  last_new_move:
    pos: 0x2aae4c
    type: move
    doc: |-
      Move struct of the last new move introduced when learning a new move. Persists even after the move selection is made in the menu.

      type: struct move
  script_vars_values:
    pos: 0x2ab0ac
    type: script_var_value_table
    doc: |-
      The table of game variable values. Its structure is determined by SCRIPT_VARS.

      Note that with the script variable list defined in SCRIPT_VARS, the used length of this table is actually only 0x2B4. However, the real length of this table is 0x400 based on the game code.

      type: struct script_var_value_table
  bag_level:
    pos: 0x2ab15c
    type: u1
    doc: The player's bag level, which determines the bag capacity. This indexes
      directly into the BAG_CAPACITY_TABLE in the ARM9 binary.
  debug_special_episode_number:
    pos: 0x2ab4ac
    type: special_episode_type_8
    doc: |-
      The number of the special episode currently being played.

      This backs the EXECUTE_SPECIAL_EPISODE_TYPE script variable.

      type: struct special_episode_type_8
  kaomado_stream:
    pos: 0x2ab4b0
    type: file_stream
    doc: |-
      The file stream utilized for all Kaomado portrait loads.

      type: struct file_stream
  pending_dungeon_id:
    pos: 0x2ab4fc
    type: dungeon_id_8
    doc: |-
      The ID of the selected dungeon when setting off from the overworld.

      Controls the text and map location during the "map cutscene" just before entering a dungeon, as well as the actual dungeon loaded afterwards.

      This field is actually part of a larger struct that also contains PENDING_STARTING_FLOOR.

      type: struct dungeon_id_8
  pending_starting_floor:
    pos: 0x2ab4fd
    type: u1
    doc: The floor number to start from in the dungeon specified by 
      PENDING_DUNGEON_ID.
  play_time_seconds:
    pos: 0x2ab694
    type: u4
    doc: The player's total play time in seconds.
  play_time_frame_counter:
    pos: 0x2ab698
    type: u1
    doc: Counts from 0-59 in a loop, with the play time being incremented by 1 
      second with each rollover.
  team_name:
    pos: 0x2ab918
    type: team_name_array
    doc: |-
      The team name.

      A null-terminated string, with a maximum length of 10 (or 5 in JP). Presumably encoded with the ANSI/Shift JIS encoding the game typically uses.

      This is presumably part of a larger struct, together with other nearby data.
  level_up_data_monster_id:
    pos: 0x2ab92c
    type: monster_id_16
    doc: ID of the monster whose level-up data is currently stored in 
      LEVEL_UP_DATA_DECOMPRESS_BUFFER.
  level_up_data_decompress_buffer:
    pos: 0x2ab930
    type: level_up_data_decompress_buffer_array
    doc: |-
      Buffer used to stored a monster's decompressed level up data. Used by GetLvlUpEntry.

      Exact size is a guess (100 levels * 12 bytes per entry = 1200 = 0x4B0).
  team_member_table:
    pos: 0x2abde0
    type: team_member_table
    doc: |-
      Table with all team members, persistent information about them, and information about which ones are currently active.

      See the comments on struct team_member_table for more information.

      type: struct team_member_table
  disp_mode:
    pos: 0x2b9588
    type: u2
    doc: This symbol is missing documentation.
  gxi_vram_lock_id:
    pos: 0x2b958a
    type: u2
    doc: This symbol is missing documentation.
  enabled_vram_banks:
    pos: 0x2b958c
    type: vram_banks_set
    doc: |-
      Bitset of enabled VRAM banks

      type: vram_banks_set
  sub_bg_ext_pltt:
    pos: 0x2b95a8
    type: u4
    doc: This symbol is missing documentation.
  clr_img:
    pos: 0x2b95c4
    type: u4
    doc: This symbol is missing documentation.
  thread_info_struct:
    pos: 0x2b9648
    type: thread_info
    doc: thread_info struct that contains global state about threads
  frames_since_launch_times_three:
    pos: 0x2b99c4
    type: u4
    doc: Starts at 0 when the game is first launched, and ticks up by 3 per 
      frame while the game is running.
  ground_memory_arena_1_ptr:
    pos: 0x324cb4
    type: pointer
    doc: Pointer to GROUND_MEMORY_ARENA_1.
  ground_memory_arena_2_ptr:
    pos: 0x324cb8
    type: pointer
    doc: Pointer to GROUND_MEMORY_ARENA_2.
  lock_notify_array:
    pos: 0x324eb4
    type: lock_notify_array_array
    doc: |-
      Used to notify scripts waiting for a certain lock to unlock so they can resume their execution.

      1 byte per lock.
  ground_memory_arena_1:
    pos: 0x324fc0
    type: mem_arena
    doc: |-
      This is a top-level memory arena used for some things in ground mode.

      It's used for user_flags 8, 15, and 16.

      Including the allocator metadata, this arena occupies 0x64000 bytes of space.

      type: struct mem_arena
  ground_memory_arena_1_blocks:
    pos: 0x324fdc
    type: ground_memory_arena_1_blocks_array
    doc: |-
      The block array for GROUND_MEMORY_ARENA_1.

      type: struct mem_block[52]
  ground_memory_arena_1_memory:
    pos: 0x3254bc
    type: ground_memory_arena_1_memory_array
    doc: The memory region for GROUND_MEMORY_ARENA_1.
  sentry_duty_struct:
    pos: 0x37a5d0
    type: sentry_duty
    doc: This symbol is missing documentation.
  turning_on_the_spot_flag:
    pos: 0x37c9a6
    type: u1
    doc: '[Runtime] Flag for whether the player is turning on the spot (pressing Y).'
  loaded_attack_sprite_data:
    pos: 0x37c9ac
    type: pointer
    doc: |-
      [Runtime] Pointer to the dynamically allocated structure relating to the currently loaded attack sprite, in dungeon mode.

      type: struct loaded_attack_sprite_data*
  mobility_type_to_dungeon_mobility_type:
    pos: 0x37c9b8
    type: mobility_type_to_dungeon_mobility_type_array
    doc: "[Runtime] Used by GetMobilityTypeCheckSlip to determine if a monster with
      a mobility type of MOBILITY_WATER or MOBILITY_LAVA can cross the current dungeon's
      liquid (lava or water). Only the values at indexes 4 (MOBILITY_LAVA) and 5 (MOBILITY_WATER)
      are used. If the mobility type can cross the liquid in the current dungeon,
      the array value at the mobility type's index is MOBILITY_WATER. If not, the
      array value is MOBILITY_NORMAL."
  ai_thrown_item_direction_is_used:
    pos: 0x37c9d0
    type: ai_thrown_item_direction_is_used_array
    doc: '[Runtime] Used in GetPossibleAiThrownItemDirections to indicate whether
      a certain direction enum value is already being used or not.'
  ai_thrown_item_probabilities:
    pos: 0x37c9d8
    type: ai_thrown_item_probabilities_array
    doc: '[Runtime] Used to store the probabilities matching the directions in THROWN_ITEM_DIRECTIONS.'
  ai_thrown_item_directions:
    pos: 0x37c9f8
    type: ai_thrown_item_directions_array
    doc: '[Runtime] Used to store the directions output by GetPossibleAiThrownItemDirections.'
  ai_can_attack_in_direction:
    pos: 0x37ca18
    type: ai_can_attack_in_direction_array
    doc: '[Runtime] Stores whether the AI can use an attack in each direction.'
  ai_potential_attack_target_directions:
    pos: 0x37ca20
    type: ai_potential_attack_target_directions_array
    doc: '[Runtime] Stores the directions that the AI can use an attack in. Parallel
      to AI_POTENTIAL_ATTACK_TARGET_WEIGHTS and AI_POTENTIAL_ATTACK_TARGETS.'
  ai_potential_attack_target_weights:
    pos: 0x37ca28
    type: ai_potential_attack_target_weights_array
    doc: '[Runtime] Stores the targeting weights for each direction the AI can use
      an attack in. Parallel to AI_POTENTIAL_ATTACK_TARGET_DIRECTIONS and AI_POTENTIAL_ATTACK_TARGETS.'
  ai_potential_attack_targets:
    pos: 0x37ca48
    type: ai_potential_attack_targets_array
    doc: '[Runtime] Stores the target entity for each direction the AI can use an
      attack in. Parallel to AI_POTENTIAL_ATTACK_TARGET_DIRECTIONS and AI_POTENTIAL_ATTACK_TARGET_DIRECTIONS.'
  rollout_ice_ball_missed:
    pos: 0x37ca69
    type: u1
    doc: '[Runtime] Appears to be set to true whenever a hit from Rollout or Ice Ball
      fails to deal damage.'
  multihit_fatigue_move_used:
    pos: 0x37ca6a
    type: u1
    doc: '[Runtime] Appears to be set to true whenever a multihit fatigue move deals
      damage.'
  twineedle_hit_tracker:
    pos: 0x37ca6b
    type: u1
    doc: '[Runtime] Appears to be set to true whenever Twineedle hits and deals damage.
      So that even if the second attack misses, it will still try to poison the target.'
  rapid_spin_binding_removal:
    pos: 0x37ca6d
    type: u1
    doc: '[Runtime] Appears to be set to true when using Rapid Spin to later remove
      any binding effects and Leech Seed.'
  rollout_ice_ball_successive_hits:
    pos: 0x37ca70
    type: s4
    doc: '[Runtime] Seems to count the number of successive hits by Rollout or Ice
      Ball.'
  multihit_move_successive_hits:
    pos: 0x37ca78
    type: s4
    doc: '[Runtime] Seems to count the number of successive hits for multihit moves.
      This is used by Twineedle to check to attempt to apply Poison after the second
      attack.'
  triple_kick_successive_hits:
    pos: 0x37ca7c
    type: s4
    doc: '[Runtime] Seems to count the number of successive hits by Triple Kick.'
  metronome_next_index:
    pos: 0x37ca88
    type: s4
    doc: '[Runtime] The index into METRONOME_TABLE for the next usage of Metronome.'
  floor_generation_status:
    pos: 0x37cfbc
    type: floor_generation_status
    doc: |-
      [Runtime] Status data related to generation of the current floor in a dungeon.

      This data is populated as the dungeon floor is generated.

      type: struct floor_generation_status
