meta:
  id: ram_data
  endian: le
instances:
  default_memory_arena_memory:
    pos: 0xb4bc0
    doc: |-
      The memory region for the default memory arena.

      The length is defined by DEFAULT_MEMORY_ARENA_SIZE.

      One mode that uses this region for heap allocations is dungeon mode.
    type: u1
    repeat: expr
    repeat-expr: 1991680
  ground_memory_arena_2:
    pos: 0x145a08
    doc: |-
      This is a memory subarena under DEFAULT_MEMORY_ARENA used for some things in ground mode.

      It's used for user_flags 14.

      Including the allocator metadata, this arena occupies 0xB0000 bytes of space.

      type: struct mem_arena
    type: mem_arena
  ground_memory_arena_2_blocks:
    pos: 0x145a24
    doc: |-
      The block array for GROUND_MEMORY_ARENA_2.

      type: struct mem_block[32]
    type: mem_block
    repeat: expr
    repeat-expr: 32
  ground_memory_arena_2_memory:
    pos: 0x145d24
    doc: The memory region for GROUND_MEMORY_ARENA_2.
    type: u1
    repeat: expr
    repeat-expr: 720100
  dungeon_colormap_ptr:
    pos: 0x1b9cf4
    doc: |-
      Pointer to a colormap used to render colors in a dungeon.

      The colormap is a list of 4-byte RGB colors of the form {R, G, B, padding}, which the game indexes into when rendering colors. Some weather conditions modify the colormap, which is how the color scheme changes when it's, e.g., raining.
    type: u4
  dungeon_struct:
    pos: 0x1b9d34
    doc: |-
      The dungeon context struct used for tons of stuff in dungeon mode. See struct dungeon in the C headers.

      This struct never seems to be referenced directly, and is instead usually accessed via DUNGEON_PTR in overlay 29.

      type: struct dungeon
    size: 0x2cb14
  move_data_table:
    pos: 0x2113cc
    doc: |-
      The move data table loaded directly from /BALANCE/waza_p.bin. See struct move_data_table in the C headers.

      Pointed to by MOVE_DATA_TABLE_PTR in the ARM 9 binary.

      type: struct move_data_table
    type: move_data_table
  sound_memory_arena:
    pos: 0x24efa0
    doc: |-
      This is a memory subarena under DEFAULT_MEMORY_ARENA that seems to be used exclusively for sound data.

      Including allocator metadata, this subarena occupies 0x3C000 bytes of space within the default arena.

      It's referenced by various sound functions like LoadDseFile, PlaySeLoad, and PlayBgm when allocating memory.

      type: struct mem_arena
    type: mem_arena
  sound_memory_arena_blocks:
    pos: 0x24efbc
    doc: |-
      The block array for SOUND_MEMORY_ARENA.

      type: struct mem_block[20]
    type: mem_block
    repeat: expr
    repeat-expr: 20
  sound_memory_arena_memory:
    pos: 0x24f19c
    doc: |-
      The memory region for SOUND_MEMORY_ARENA.

      This region appears to be used for sound-related heap allocations, like when loading sound files into memory.
    type: u1
    repeat: expr
    repeat-expr: 245252
  frames_since_launch_0:
    pos: 0x2a354c
    doc: Starts at 0 when the game is first launched, and continuously ticks up once
      per frame while the game is running.
    type: u4
  frames_since_launch_1:
    pos: 0x2a359c
    doc: Starts at 0 when the game is first launched, and continuously ticks up once
      per frame while the game is running.
    type: u4
  touchscreen_status:
    pos: 0x2a35dc
    doc: Status of the touchscreen, including the coordinates of the currently pressed
      position in pixels.
    type: touchscreen_status
  bag_items:
    pos: 0x2a3824
    doc: |-
      Array of item structs within the player's bag.

      While the game only allows a maximum of 48 items during normal play, it seems to read up to 50 item slots if filled.

      type: struct item[50]
    type: item
    repeat: expr
    repeat-expr: 50
  bag_items_ptr:
    pos: 0x2a3ba8
    doc: Pointer to BAG_ITEMS.
    type: u4
  storage_items:
    pos: 0x2a3bae
    doc: |-
      Array of item IDs in the player's item storage.

      For stackable items, the quantities are stored elsewhere, in STORAGE_ITEM_QUANTITIES.

      type: struct item_id_16[1000]
    size: 0x7d0
  storage_item_quantities:
    pos: 0x2a437e
    doc: |-
      Array of 1000 2-byte (unsigned) quantities corresponding to the item IDs in STORAGE_ITEMS.

      If the corresponding item ID is not a stackable item, the entry in this array is unused, and will be 0.
    type: u2
    repeat: expr
    repeat-expr: 1000
  kecleon_shop_items_ptr:
    pos: 0x2a4b50
    doc: Pointer to KECLEON_SHOP_ITEMS.
    type: u4
  kecleon_shop_items:
    pos: 0x2a4b54
    doc: |-
      Array of up to 8 items in the Kecleon Shop.

      If there are fewer than 8 items, the array is expected to be null-terminated.

      type: struct bulk_item[8]
    type: bulk_item
    repeat: expr
    repeat-expr: 8
  unused_kecleon_shop_items:
    pos: 0x2a4b74
    doc: Seems to be another array like KECLEON_SHOP_ITEMS, but don't actually appear
      to be used by the Kecleon Shop.
    type: bulk_item
    repeat: expr
    repeat-expr: 8
  kecleon_wares_items_ptr:
    pos: 0x2a4b94
    doc: Pointer to KECLEON_WARES_ITEMS.
    type: u4
  kecleon_wares_items:
    pos: 0x2a4b98
    doc: |-
      Array of up to 4 items in Kecleon Wares.

      If there are fewer than 4 items, the array is expected to be null-terminated.

      type: struct bulk_item[4]
    type: bulk_item
    repeat: expr
    repeat-expr: 4
  unused_kecleon_wares_items:
    pos: 0x2a4ba8
    doc: Seems to be another array like KECLEON_WARES_ITEMS, but don't actually appear
      to be used by Kecleon Wares.
    type: bulk_item
    repeat: expr
    repeat-expr: 4
  money_carried:
    pos: 0x2a4bb8
    doc: The amount of money the player is currently carrying.
    type: s4
  money_stored:
    pos: 0x2a4bc4
    doc: The amount of money the player currently has stored in the Duskull Bank.
    type: s4
  audio_commands_buffer:
    pos: 0x2a4c50
    doc: Buffer used to store audio commands. 16 entries in total. Seems like entries
      are removed at some point (maybe after the commands are read or after they finish
      executing).
    type: audio_command
    repeat: expr
    repeat-expr: 16
  sound_memory_arena_ptr:
    pos: 0x2a4e54
    doc: Pointer to SOUND_MEMORY_ARENA.
    type: u4
  window_list:
    pos: 0x2a88dc
    doc: |-
      Array of all window structs. Newly created window structs are taken from slots in this array.

      Note that this array isn't strictly ordered in any way. A newly created window will occupy the first available slot. If a window in an early slot is destroyed, windows that are still active in later slots won't be shifted back unless destroyed and recreated.

      type: struct window_list
    type: window_list
  cursor_16_sprite_id:
    pos: 0x2aac64
    doc: Id of the "FONT/cursor_16.wan" sprite loaded in WAN_TABLE
    type: u2
  cursor_animation_control:
    pos: 0x2aac80
    doc: animation_control of "FONT/cursor.wan"
    type: u4
  cursor_16_animation_control:
    pos: 0x2aacfc
    doc: animation_control of "FONT/cursor_16.wan"
    type: u4
  alert_sprite_id:
    pos: 0x2aad78
    doc: Id of the "FONT/alert.wan" sprite loaded in WAN_TABLE
    type: u2
  alert_animation_control:
    pos: 0x2aad7c
    doc: animation_control of "FONT/alter.wan"
    type: u4
  last_new_move:
    pos: 0x2aae4c
    doc: |-
      Move struct of the last new move introduced when learning a new move. Persists even after the move selection is made in the menu.

      type: struct move
    type: move
  script_vars_values:
    pos: 0x2ab0ac
    doc: |-
      The table of game variable values. Its structure is determined by SCRIPT_VARS.

      Note that with the script variable list defined in SCRIPT_VARS, the used length of this table is actually only 0x2B4. However, the real length of this table is 0x400 based on the game code.

      type: struct script_var_value_table
    type: script_var_value_table
  bag_level:
    pos: 0x2ab15c
    doc: The player's bag level, which determines the bag capacity. This indexes directly
      into the BAG_CAPACITY_TABLE in the ARM9 binary.
    type: u1
  debug_special_episode_number:
    pos: 0x2ab4ac
    doc: |-
      The number of the special episode currently being played.

      This backs the EXECUTE_SPECIAL_EPISODE_TYPE script variable.

      type: struct special_episode_type_8
    size: 0x1
  kaomado_stream:
    pos: 0x2ab4b0
    doc: |-
      The file stream utilized for all Kaomado portrait loads.

      type: struct file_stream
    type: file_stream
  pending_dungeon_id:
    pos: 0x2ab4fc
    doc: |-
      The ID of the selected dungeon when setting off from the overworld.

      Controls the text and map location during the "map cutscene" just before entering a dungeon, as well as the actual dungeon loaded afterwards.

      This field is actually part of a larger struct that also contains PENDING_STARTING_FLOOR.

      type: struct dungeon_id_8
    size: 0x1
  pending_starting_floor:
    pos: 0x2ab4fd
    doc: The floor number to start from in the dungeon specified by PENDING_DUNGEON_ID.
    type: u1
  play_time_seconds:
    pos: 0x2ab694
    doc: The player's total play time in seconds.
    type: u4
  play_time_frame_counter:
    pos: 0x2ab698
    doc: Counts from 0-59 in a loop, with the play time being incremented by 1 second
      with each rollover.
    type: u1
  team_name:
    pos: 0x2ab918
    doc: |-
      The team name.

      A null-terminated string, with a maximum length of 10 (or 5 in JP). Presumably encoded with the ANSI/Shift JIS encoding the game typically uses.

      This is presumably part of a larger struct, together with other nearby data.
    type: s1
  level_up_data_monster_id:
    pos: 0x2ab92c
    doc: ID of the monster whose level-up data is currently stored in LEVEL_UP_DATA_DECOMPRESS_BUFFER.
    size: 0x2
  level_up_data_decompress_buffer:
    pos: 0x2ab930
    doc: |-
      Buffer used to stored a monster's decompressed level up data. Used by GetLvlUpEntry.

      Exact size is a guess (100 levels * 12 bytes per entry = 1200 = 0x4B0).
    type: level_up_entry
    repeat: expr
    repeat-expr: 100
  team_member_table:
    pos: 0x2abde0
    doc: |-
      Table with all team members, persistent information about them, and information about which ones are currently active.

      See the comments on struct team_member_table for more information.

      type: struct team_member_table
    type: team_member_table
  disp_mode:
    pos: 0x2b9588
    type: u2
  gxi_vram_lock_id:
    pos: 0x2b958a
    type: u2
  enabled_vram_banks:
    pos: 0x2b958c
    doc: |-
      Bitset of enabled VRAM banks

      type: vram_banks_set
    type: vram_banks_set
  sub_bg_ext_pltt:
    pos: 0x2b95a8
    type: u4
  clr_img:
    pos: 0x2b95c4
    type: u4
  thread_info_struct:
    pos: 0x2b9648
    doc: thread_info struct that contains global state about threads
    type: thread_info
  frames_since_launch_times_three:
    pos: 0x2b99c4
    doc: Starts at 0 when the game is first launched, and ticks up by 3 per frame
      while the game is running.
    type: u4
  ground_memory_arena_1_ptr:
    pos: 0x324cb4
    doc: Pointer to GROUND_MEMORY_ARENA_1.
    type: u4
  ground_memory_arena_2_ptr:
    pos: 0x324cb8
    doc: Pointer to GROUND_MEMORY_ARENA_2.
    type: u4
  lock_notify_array:
    pos: 0x324eb4
    doc: |-
      Used to notify scripts waiting for a certain lock to unlock so they can resume their execution.

      1 byte per lock.
    size: 0x18
  ground_memory_arena_1:
    pos: 0x324fc0
    doc: |-
      This is a top-level memory arena used for some things in ground mode.

      It's used for user_flags 8, 15, and 16.

      Including the allocator metadata, this arena occupies 0x64000 bytes of space.

      type: struct mem_arena
    type: mem_arena
  ground_memory_arena_1_blocks:
    pos: 0x324fdc
    doc: |-
      The block array for GROUND_MEMORY_ARENA_1.

      type: struct mem_block[52]
    type: mem_block
    repeat: expr
    repeat-expr: 52
  ground_memory_arena_1_memory:
    pos: 0x3254bc
    doc: The memory region for GROUND_MEMORY_ARENA_1.
    type: u1
    repeat: expr
    repeat-expr: 408324
  sentry_duty_struct:
    pos: 0x37a5d0
    type: sentry_duty
  turning_on_the_spot_flag:
    pos: 0x37c9a6
    doc: '[Runtime] Flag for whether the player is turning on the spot (pressing Y).'
    size: 0x1
  loaded_attack_sprite_data:
    pos: 0x37c9ac
    doc: |-
      [Runtime] Pointer to the dynamically allocated structure relating to the currently loaded attack sprite, in dungeon mode.

      type: struct loaded_attack_sprite_data*
    type: u4
  ai_thrown_item_direction_is_used:
    pos: 0x37c9d0
    doc: '[Runtime] Used in GetPossibleAiThrownItemDirections to indicate whether
      a certain direction enum value is already being used or not.'
    size: 0x8
  ai_thrown_item_probabilities:
    pos: 0x37c9d8
    doc: '[Runtime] Used to store the probabilities matching the directions in THROWN_ITEM_DIRECTIONS.'
    type: u4
    repeat: expr
    repeat-expr: 8
  ai_thrown_item_directions:
    pos: 0x37c9f8
    doc: '[Runtime] Used to store the directions output by GetPossibleAiThrownItemDirections.'
    type: u4
    repeat: expr
    repeat-expr: 8
  rollout_ice_ball_missed:
    pos: 0x37ca69
    doc: '[Runtime] Appears to be set to true whenever a hit from Rollout or Ice Ball
      fails to deal damage.'
    size: 0x1
  multihit_fatigue_move_used:
    pos: 0x37ca6a
    doc: '[Runtime] Appears to be set to true whenever a multihit fatigue move deals
      damage.'
    size: 0x1
  twineedle_hit_tracker:
    pos: 0x37ca6b
    doc: '[Runtime] Appears to be set to true whenever Twineedle hits and deals damage.
      So that even if the second attack misses, it will still try to poison the target.'
    size: 0x1
  rapid_spin_binding_removal:
    pos: 0x37ca6d
    doc: '[Runtime] Appears to be set to true when using Rapid Spin to later remove
      any binding effects and Leech Seed.'
    size: 0x1
  rollout_ice_ball_successive_hits:
    pos: 0x37ca70
    doc: '[Runtime] Seems to count the number of successive hits by Rollout or Ice
      Ball.'
    type: s4
  multihit_move_successive_hits:
    pos: 0x37ca78
    doc: '[Runtime] Seems to count the number of successive hits for multihit moves.
      This is used by Twineedle to check to attempt to apply Poison after the second
      attack.'
    type: s4
  triple_kick_successive_hits:
    pos: 0x37ca7c
    doc: '[Runtime] Seems to count the number of successive hits by Triple Kick.'
    type: s4
  metronome_next_index:
    pos: 0x37ca88
    doc: '[Runtime] The index into METRONOME_TABLE for the next usage of Metronome.'
    type: s4
  floor_generation_status:
    pos: 0x37cfbc
    doc: |-
      [Runtime] Status data related to generation of the current floor in a dungeon.

      This data is populated as the dungeon floor is generated.

      type: struct floor_generation_status
    type: floor_generation_status
types:
  mem_arena:
  - id: content_flags
    type: u4
  - id: n_blocks
    type: u4
  - id: max_blocks
    type: u4
  - id: len
    type: u4
  mem_block:
  - id: available
    type: u4
  - id: used
    type: u4
  move_data_table: []
  touchscreen_status:
  - id: current_position
    type: touchscreen_position
  - id: field_0xC
    type: u1
  - id: field_0xD
    type: u1
  - id: field_0xE
    type: u1
  - id: field_0xF
    type: u1
  - id: pressed_frames
    type: s4
  - id: unpressed_frames
    type: s4
  - id: x_pos_mirror
    type: s4
  - id: y_pos_mirror
    type: s4
  - id: last_x_pos
    type: s4
  - id: last_y_pos
    type: s4
  - id: first_x_pos
    type: s4
  - id: first_y_pos
    type: s4
  - id: field_0x30
    type: u1
  - id: field_0x31
    type: u1
  - id: field_0x32
    type: u1
  - id: field_0x33
    type: u1
  - id: field_0x34
    type: u1
  - id: field_0x35
    type: u1
  - id: field_0x36
    type: u1
  - id: field_0x37
    type: u1
  - id: current_position_mirror
    type: touchscreen_position
  - id: current_position_mirror_1
    type: touchscreen_position
  - id: current_position_mirror_2
    type: touchscreen_position
  - id: current_position_mirror_3
    type: touchscreen_position
  item:
  - id: held_by
    type: u1
  - id: quantity
    type: u2
  - id: id
    type: item_id_16
  bulk_item:
  - id: id
    type: item_id_16
  - id: quantity
    type: u2
  audio_command:
  - id: status
    type: s4
  - id: music_id
    type: music_id_16
  - id: volume
    type: u2
  - id: field_0x8
    type: u2
  - id: field_0xA
    type: u1
  - id: field_0xB
    type: u1
  - id: field_0xC
    type: u1
  - id: field_0xD
    type: u1
  - id: field_0xE
    type: u1
  - id: field_0xF
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
  - id: field_0x16
    type: u1
  - id: field_0x17
    type: u1
  - id: field_0x18
    type: u1
  - id: field_0x19
    type: u1
  - id: field_0x1A
    type: u1
  - id: field_0x1B
    type: u1
  - id: field_0x1C
    type: u1
  - id: field_0x1D
    type: u1
  - id: field_0x1E
    type: u1
  - id: field_0x1F
    type: u1
  window_list: []
  move:
  - id: field_0x1
    type: u1
  - id: id
    type: move_id_16
  - id: pp
    type: u1
  - id: ginseng
    type: u1
  script_var_value_table:
  - id: version
    type: s4
  - id: condition
    type: s4
  - id: recycle_count
    type: u4
  - id: ground_enter
    type: s2
  - id: ground_getout
    type: s2
  - id: ground_map
    type: s2
  - id: ground_place
    type: s2
  - id: dungeon_select
    type: s2
  - id: dungeon_enter
    type: s2
  - id: dungeon_enter_mode
    type: s2
  - id: dungeon_enter_index
    type: s2
  - id: hero_first_kind
    type: s2
  - id: partner_first_kind
    type: s2
  - id: random_request_npc03_kind
    type: s2
  - id: event_local
    type: s2
  - id: dungeon_event_local
    type: s2
  - id: request_thanks_result_kind
    type: s2
  - id: request_thanks_result_variation
    type: s2
  - id: dungeon_enter_frequency
    type: u2
  - id: scenario_balance_flag
    type: s1
  - id: scenario_balance_debug
    type: s1
  - id: hero_talk_kind
    type: s1
  - id: partner_talk_kind
    type: s1
  - id: config_color_kind
    type: s1
  - id: rom_variation
    type: s1
  - id: special_episode_type
    type: s1
  - id: crystal_color_01
    type: u1
  - id: crystal_color_02
    type: u1
  - id: crystal_color_03
    type: u1
  - id: compulsory_save_point
    type: u1
  - id: compulsory_save_point_side
    type: u1
  - id: ground_enter_link
    type: u1
  - id: dungeon_result
    type: u1
  - id: ground_start_mode
    type: u1
  - id: request_clear_count
    type: u1
  - id: player_kind
    type: u1
  - id: attendant1_kind
    type: u1
  - id: attendant2_kind
    type: u1
  - id: world_map_level
    type: u1
  - id: lottery_result
    type: u1
  - id: sub30_spot_level
    type: u1
  - id: team_rank_event_level
    type: u1
  - id: play_old_game
    type: u1
  file_stream:
  - id: field_0x0
    type: u4
  - id: field_0x4
    type: u4
  - id: field_0x8
    type: u4
  - id: field_0xc
    type: u4
  - id: field_0x10
    type: u4
  - id: field_0x14
    type: u4
  - id: field_0x18
    type: u4
  - id: field_0x1c
    type: u4
  - id: field_0x20
    type: u4
  - id: field_0x30
    type: u4
  - id: field_0x34
    type: u4
  - id: field_0x38
    type: u4
  - id: field_0x3c
    type: u4
  - id: field_0x40
    type: u4
  - id: field_0x44
    type: u4
  level_up_entry:
  - id: total_exp
    type: u4
  - id: hp
    type: u2
  - id: atk
    type: u1
  - id: sp_atk
    type: u1
  - id: def
    type: u1
  - id: sp_def
    type: u1
  - id: field_0xA
    type: u1
  - id: field_0xB
    type: u1
  team_member_table:
  - id: floor
    type: the
  - id: number_active_team_members_main
    type: s2
  - id: number_active_team_members_se
    type: s2
  - id: number_active_team_members_rescue
    type: s2
  - id: field_0x986e
    type: u1
  - id: field_0x986f
    type: u1
  - id: field_0x9874
    type: u1
  - id: field_0x9875
    type: u1
  - id: field_0x9876
    type: u1
  - id: active_team
    type: team_id_8
  - id: field_0x9878
    type: u4
  - id: field_0x987C
    type: u4
  - id: explorer_maze_team_native_language
    type: s1
  - id: field_0x9881
    type: u1
  - id: field_0x9896
    type: u1
  - id: field_0x9897
    type: u1
  vram_banks_set: []
  thread_info:
  - id: field_0x0
    type: u1
  - id: field_0x1
    type: u1
  - id: field_0x2
    type: u1
  - id: field_0x3
    type: u1
  - id: field_0x4
    type: u1
  - id: field_0x5
    type: u1
  - id: field_0x6
    type: u1
  - id: field_0x7
    type: u1
  - id: field_0xC
    type: u1
  - id: field_0xD
    type: u1
  - id: field_0xE
    type: u1
  - id: field_0xF
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
  - id: field_0x16
    type: u1
  - id: field_0x17
    type: u1
  - id: field_0x18
    type: u1
  - id: field_0x19
    type: u1
  - id: field_0x1A
    type: u1
  - id: field_0x1B
    type: u1
  - id: field_0x1C
    type: u1
  - id: field_0x1D
    type: u1
  - id: field_0x1E
    type: u1
  - id: field_0x1F
    type: u1
  - id: thread_count
    type: s4
  - id: field_0x24
    type: u1
  - id: field_0x25
    type: u1
  - id: field_0x26
    type: u1
  - id: field_0x27
    type: u1
  - id: field_0x30
    type: u1
  - id: field_0x31
    type: u1
  - id: field_0x32
    type: u1
  - id: field_0x33
    type: u1
  sentry_duty:
  - id: field_0x0
    type: u1
  - id: field_0x1
    type: u1
  - id: field_0x2
    type: u1
  - id: field_0x3
    type: u1
  - id: field_0x4
    type: u1
  - id: field_0x5
    type: u1
  - id: field_0x6
    type: u1
  - id: field_0x7
    type: u1
  - id: field_0x8
    type: u1
  - id: field_0x9
    type: u1
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  - id: field_0xc
    type: s4
  - id: field_0x10
    type: s4
  - id: field_0x14
    type: s4
  - id: field_0x18
    type: s4
  - id: field_0x1c
    type: u1
  - id: field_0x1d
    type: u1
  - id: field_0x1e
    type: u1
  - id: field_0x1f
    type: u1
  - id: field_0x20
    type: u1
  - id: field_0x21
    type: u1
  - id: field_0x22
    type: u1
  - id: field_0x23
    type: u1
  - id: field_0x24
    type: u1
  - id: field_0x25
    type: u1
  - id: field_0x26
    type: u1
  - id: field_0x27
    type: u1
  - id: field_0x28
    type: u1
  - id: field_0x29
    type: u1
  - id: field_0x2a
    type: u1
  - id: field_0x2b
    type: u1
  - id: field_0x2c
    type: u1
  - id: field_0x2d
    type: u1
  - id: field_0x2e
    type: u1
  - id: field_0x2f
    type: u1
  - id: field_0x30
    type: u1
  - id: field_0x31
    type: u1
  - id: field_0x32
    type: u1
  - id: field_0x33
    type: u1
  - id: field_0x34
    type: u1
  - id: field_0x35
    type: u1
  - id: field_0x36
    type: u1
  - id: field_0x37
    type: u1
  - id: field_0x38
    type: u1
  - id: field_0x39
    type: u1
  - id: field_0x3a
    type: u1
  - id: field_0x3b
    type: u1
  - id: field_0x3c
    type: u1
  - id: field_0x3d
    type: u1
  - id: field_0x3e
    type: u1
  - id: field_0x3f
    type: u1
  - id: field_0x40
    type: u1
  - id: field_0x41
    type: u1
  - id: field_0x42
    type: u1
  - id: field_0x43
    type: u1
  - id: field_0x44
    type: u1
  - id: field_0x45
    type: u1
  - id: field_0x46
    type: u1
  - id: field_0x47
    type: u1
  - id: field_0x48
    type: u1
  - id: field_0x49
    type: u1
  - id: field_0x4a
    type: u1
  - id: field_0x4b
    type: u1
  - id: field_0x4c
    type: u1
  - id: field_0x4d
    type: u1
  - id: field_0x4e
    type: u1
  - id: field_0x4f
    type: u1
  - id: field_0x50
    type: u1
  - id: field_0x51
    type: u1
  - id: field_0x52
    type: u1
  - id: field_0x53
    type: u1
  - id: field_0x54
    type: u1
  - id: field_0x55
    type: u1
  - id: field_0x56
    type: u1
  - id: field_0x57
    type: u1
  - id: field_0x58
    type: u1
  - id: field_0x59
    type: u1
  - id: field_0x5a
    type: u1
  - id: field_0x5b
    type: u1
  - id: field_0x5c
    type: u1
  - id: field_0x5d
    type: u1
  - id: field_0x5e
    type: u1
  - id: field_0x5f
    type: u1
  - id: field_0x60
    type: u1
  - id: field_0x61
    type: u1
  - id: field_0x62
    type: u1
  - id: field_0x63
    type: u1
  - id: field_0x64
    type: u1
  - id: field_0x65
    type: u1
  - id: field_0x66
    type: u1
  - id: field_0x67
    type: u1
  - id: field_0x68
    type: u1
  - id: field_0x69
    type: u1
  - id: field_0x6a
    type: u1
  - id: field_0x6b
    type: u1
  - id: field_0x6c
    type: u1
  - id: field_0x6d
    type: u1
  - id: field_0x6e
    type: u1
  - id: field_0x6f
    type: u1
  - id: field_0x70
    type: u1
  - id: field_0x71
    type: u1
  - id: field_0x72
    type: u1
  - id: field_0x73
    type: u1
  - id: field_0x74
    type: u1
  - id: field_0x75
    type: u1
  - id: field_0x76
    type: u1
  - id: field_0x77
    type: u1
  - id: field_0x78
    type: u1
  - id: field_0x79
    type: u1
  - id: field_0x7a
    type: u1
  - id: field_0x7b
    type: u1
  - id: field_0x7c
    type: u1
  - id: field_0x7d
    type: u1
  - id: field_0x7e
    type: u1
  - id: field_0x7f
    type: u1
  - id: field_0x80
    type: u1
  - id: field_0x81
    type: u1
  - id: field_0x82
    type: u1
  - id: field_0x83
    type: u1
  - id: field_0x84
    type: u1
  - id: field_0x85
    type: u1
  - id: field_0x86
    type: u1
  - id: field_0x87
    type: u1
  - id: field_0x88
    type: u1
  - id: field_0x89
    type: u1
  - id: field_0x8a
    type: u1
  - id: field_0x8b
    type: u1
  - id: field_0x8c
    type: u1
  - id: field_0x8d
    type: u1
  - id: field_0x8e
    type: u1
  - id: field_0x8f
    type: u1
  - id: field_0x90
    type: u1
  - id: field_0x91
    type: u1
  - id: field_0x92
    type: u1
  - id: field_0x93
    type: u1
  - id: field_0x94
    type: u1
  - id: field_0x95
    type: u1
  - id: field_0x96
    type: u1
  - id: field_0x97
    type: u1
  - id: field_0x98
    type: u1
  - id: field_0x99
    type: u1
  - id: field_0x9a
    type: u1
  - id: field_0x9b
    type: u1
  - id: field_0x9c
    type: u1
  - id: field_0x9d
    type: u1
  - id: field_0x9e
    type: u1
  - id: field_0x9f
    type: u1
  - id: field_0xa0
    type: u1
  - id: field_0xa1
    type: u1
  - id: field_0xa2
    type: u1
  - id: field_0xa3
    type: u1
  - id: dialogue_args
    type: preprocessor_args
  - id: field_0xf4
    type: u1
  - id: field_0xf5
    type: u1
  - id: field_0xf6
    type: u1
  - id: field_0xf7
    type: u1
  - id: field_0xf8
    type: u1
  - id: field_0xf9
    type: u1
  - id: field_0xfa
    type: u1
  - id: field_0xfb
    type: u1
  - id: field_0xfc
    type: u1
  - id: field_0xfd
    type: u1
  - id: field_0xfe
    type: u1
  - id: field_0xff
    type: u1
  - id: field_0x100
    type: u1
  - id: field_0x101
    type: u1
  - id: field_0x102
    type: u1
  - id: field_0x103
    type: u1
  - id: completion_state
    type: sentry_completion_state
  - id: game_state
    type: s4
  - id: control_state
    type: sentry_control_state
  - id: next_game_state
    type: s4
  - id: prev_dialogue_str_id
    type: s4
  - id: field_0x118
    type: s4
  - id: field_0x11c
    type: s4
  - id: field_0x120
    type: animation
  - id: field_0x1e4
    type: animation
  - id: field_0x2a8
    type: animation
  - id: field_0x29b4
    type: animation
  - id: field_0x33a8
    type: animation
  - id: field_0x346c
    type: animation
  - id: field_0x3530
    type: u1
  - id: field_0x3531
    type: u1
  - id: field_0x3532
    type: u1
  - id: field_0x3533
    type: u1
  - id: field_0x3534
    type: s4
  - id: field_0x3538
    type: s4
  - id: field_0x353c
    type: s4
  - id: field_0x3540
    type: s4
  - id: round_display
    type: s4
  - id: field_0x3568
    type: s4
  - id: field_0x356c
    type: s4
  - id: field_0x3870
    type: u1
  - id: field_0x3871
    type: u1
  - id: field_0x3872
    type: u1
  - id: field_0x3873
    type: u1
  - id: field_0x3874
    type: s4
  - id: field_0x3878
    type: s4
  - id: right_answer_slot
    type: s4
  - id: right_answer_data_idx
    type: s4
  - id: round
    type: s4
  - id: field_0x3888
    type: s4
  - id: points
    type: s4
  - id: field_0x3890
    type: s4
  - id: field_0x3894
    type: s4
  - id: field_0x3898
    type: s4
  - id: field_0x389c
    type: u1
  - id: field_0x389d
    type: u1
  - id: field_0x389e
    type: u1
  - id: field_0x389f
    type: u1
  - id: field_0x38a0
    type: u1
  - id: field_0x38a1
    type: u1
  - id: field_0x38aa
    type: u1
  - id: field_0x38ab
    type: u1
  - id: field_0x38ac
    type: s4
  - id: field_0x38b0
    type: s4
  - id: field_0x38b4
    type: s4
  - id: hero_str_id
    type: s2
  - id: partner_str_id
    type: s2
  floor_generation_status:
  - id: second_spawn
    type: bool
  - id: has_monster_house
    type: bool
  - id: stairs_room
    type: u1
  - id: has_kecleon_shop
    type: bool
  - id: has_chasms_as_secondary_terrain
    type: bool
  - id: is_invalid
    type: bool
  - id: floor_size
    type: floor_size_8
  - id: has_maze
    type: bool
  - id: no_enemy_spawns
    type: bool
  - id: field_0x9
    type: u1
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  - id: kecleon_shop_spawn_chance
    type: s2
  - id: field_0xe
    type: u1
  - id: field_0xf
    type: u1
  - id: monster_house_spawn_chance
    type: s2
  - id: field_0x12
    type: u1
  - id: field_0x13
    type: u1
  - id: n_rooms
    type: s4
  - id: secondary_structures_budget
    type: s4
  - id: hidden_stairs_spawn
    type: position
  - id: kecleon_shop_middle
    type: position
  - id: n_tiles_reachable_from_stairs
    type: s4
  - id: layout
    type: floor_layout
  - id: hidden_stairs_type
    type: hidden_stairs_type
  - id: kecleon_shop_min_x
    type: s4
  - id: kecleon_shop_min_y
    type: s4
  - id: kecleon_shop_max_x
    type: s4
  - id: kecleon_shop_max_y
    type: s4
enums: {}
