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
    size: 0x1c
  ground_memory_arena_2_blocks:
    pos: 0x145a24
    doc: |-
      The block array for GROUND_MEMORY_ARENA_2.

      type: struct mem_block[32]
    size: 0x300
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
    size: 0x38c6
  sound_memory_arena:
    pos: 0x24efa0
    doc: |-
      This is a memory subarena under DEFAULT_MEMORY_ARENA that seems to be used exclusively for sound data.

      Including allocator metadata, this subarena occupies 0x3C000 bytes of space within the default arena.

      It's referenced by various sound functions like LoadDseFile, PlaySeLoad, and PlayBgm when allocating memory.

      type: struct mem_arena
    size: 0x1c
  sound_memory_arena_blocks:
    pos: 0x24efbc
    doc: |-
      The block array for SOUND_MEMORY_ARENA.

      type: struct mem_block[20]
    size: 0x1e0
  sound_memory_arena_memory:
    pos: 0x24f19c
    doc: |-
      The memory region for SOUND_MEMORY_ARENA.

      This region appears to be used for sound-related heap allocations, like when loading sound files into memory.
    type: u1
    repeat: expr
    repeat-expr: 245252
  touchscreen_status:
    pos: 0x2a35dc
    doc: Status of the touchscreen, including the coordinates of the currently pressed
      position in pixels.
    size: 0x104
  bag_items:
    pos: 0x2a3824
    doc: |-
      Array of item structs within the player's bag.

      While the game only allows a maximum of 48 items during normal play, it seems to read up to 50 item slots if filled.

      type: struct item[50]
    size: 0x12c
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
    size: 0x20
  unused_kecleon_shop_items:
    pos: 0x2a4b74
    doc: Seems to be another array like KECLEON_SHOP_ITEMS, but don't actually appear
      to be used by the Kecleon Shop.
    size: 0x20
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
    size: 0x10
  unused_kecleon_wares_items:
    pos: 0x2a4ba8
    doc: Seems to be another array like KECLEON_WARES_ITEMS, but don't actually appear
      to be used by Kecleon Wares.
    size: 0x10
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
    size: 0x200
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
    size: 0x1180
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
    size: 0x8
  script_vars_values:
    pos: 0x2ab0ac
    doc: |-
      The table of game variable values. Its structure is determined by SCRIPT_VARS.

      Note that with the script variable list defined in SCRIPT_VARS, the used length of this table is actually only 0x2B4. However, the real length of this table is 0x400 based on the game code.

      type: struct script_var_value_table
    size: 0x400
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
    size: 0x48
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
    size: 0x4b0
  team_member_table:
    pos: 0x2abde0
    doc: |-
      Table with all team members, persistent information about them, and information about which ones are currently active.

      See the comments on struct team_member_table for more information.

      type: struct team_member_table
    size: 0x99a8
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
    size: 0x2
  sub_bg_ext_pltt:
    pos: 0x2b95a8
    type: u4
  clr_img:
    pos: 0x2b95c4
    type: u4
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
    size: 0x1c
  ground_memory_arena_1_blocks:
    pos: 0x324fdc
    doc: |-
      The block array for GROUND_MEMORY_ARENA_1.

      type: struct mem_block[52]
    size: 0x4e0
  ground_memory_arena_1_memory:
    pos: 0x3254bc
    doc: The memory region for GROUND_MEMORY_ARENA_1.
    type: u1
    repeat: expr
    repeat-expr: 408324
  sentry_duty_struct:
    pos: 0x37a5d0
    size: 0x38d4
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
    size: 0x40
types: {}
enums: {}
