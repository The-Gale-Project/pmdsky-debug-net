meta:
  id: ram_data
  endian: le
instances:
  default_memory_arena_memory:
    pos: 0xb6420
    doc: |-
      The memory region for the default memory arena.

      The length is defined by DEFAULT_MEMORY_ARENA_SIZE.

      One mode that uses this region for heap allocations is dungeon mode.
    type: u1
    repeat: expr
    repeat-expr: 1991680
  touchscreen_status:
    pos: 0x2a4e3c
    doc: Status of the touchscreen, including the coordinates of the currently pressed
      position in pixels.
    size: 0x104
  bag_items:
    pos: 0x2a5084
    doc: |-
      Array of item structs within the player's bag.

      While the game only allows a maximum of 48 items during normal play, it seems to read up to 50 item slots if filled.

      type: struct item[50]
    size: 0x12c
  money_carried:
    pos: 0x2a6418
    doc: The amount of money the player is currently carrying.
    type: s4
  money_stored:
    pos: 0x2a6424
    doc: The amount of money the player currently has stored in the Duskull Bank.
    type: s4
  audio_commands_buffer:
    pos: 0x2a64b0
    doc: Buffer used to store audio commands. 16 entries in total. Seems like entries
      are removed at some point (maybe after the commands are read or after they finish
      executing).
    size: 0x200
  window_list:
    pos: 0x2aa0e8
    doc: |-
      Array of all window structs. Newly created window structs are taken from slots in this array.

      Note that this array isn't strictly ordered in any way. A newly created window will occupy the first available slot. If a window in an early slot is destroyed, windows that are still active in later slots won't be shifted back unless destroyed and recreated.

      type: struct window_list
    size: 0x1180
  cursor_16_sprite_id:
    pos: 0x2ac470
    doc: Id of the "FONT/cursor_16.wan" sprite loaded in WAN_TABLE
    type: u2
  cursor_animation_control:
    pos: 0x2ac48c
    doc: animation_control of "FONT/cursor.wan"
    type: u4
  cursor_16_animation_control:
    pos: 0x2ac508
    doc: animation_control of "FONT/cursor_16.wan"
    type: u4
  alert_sprite_id:
    pos: 0x2ac584
    doc: Id of the "FONT/alert.wan" sprite loaded in WAN_TABLE
    type: u2
  alert_animation_control:
    pos: 0x2ac588
    doc: animation_control of "FONT/alter.wan"
    type: u4
  last_new_move:
    pos: 0x2ac658
    doc: |-
      Move struct of the last new move introduced when learning a new move. Persists even after the move selection is made in the menu.

      type: struct move
    size: 0x8
  script_vars_values:
    pos: 0x2ac868
    doc: |-
      The table of game variable values. Its structure is determined by SCRIPT_VARS.

      Note that with the script variable list defined in SCRIPT_VARS, the used length of this table is actually only 0x2B4. However, the real length of this table is 0x400 based on the game code.

      type: struct script_var_value_table
    size: 0x400
  debug_special_episode_number:
    pos: 0x2acc68
    doc: |-
      The number of the special episode currently being played.

      This backs the EXECUTE_SPECIAL_EPISODE_TYPE script variable.

      type: struct special_episode_type_8
    size: 0x1
  kaomado_stream:
    pos: 0x2acc6c
    doc: |-
      The file stream utilized for all Kaomado portrait loads.

      type: struct file_stream
    size: 0x48
  pending_dungeon_id:
    pos: 0x2accb8
    doc: |-
      The ID of the selected dungeon when setting off from the overworld.

      Controls the text and map location during the "map cutscene" just before entering a dungeon, as well as the actual dungeon loaded afterwards.

      This field is actually part of a larger struct that also contains PENDING_STARTING_FLOOR.

      type: struct dungeon_id_8
    size: 0x1
  play_time_seconds:
    pos: 0x2ace50
    doc: The player's total play time in seconds.
    type: u4
  team_name:
    pos: 0x2ad0d4
    doc: |-
      The team name.

      A null-terminated string, with a maximum length of 10 (or 5 in JP). Presumably encoded with the ANSI/Shift JIS encoding the game typically uses.

      This is presumably part of a larger struct, together with other nearby data.
    type: s1
  level_up_data_monster_id:
    pos: 0x2ad0e4
    doc: ID of the monster whose level-up data is currently stored in LEVEL_UP_DATA_DECOMPRESS_BUFFER.
    size: 0x2
  level_up_data_decompress_buffer:
    pos: 0x2ad0e8
    doc: |-
      Buffer used to stored a monster's decompressed level up data. Used by GetLvlUpEntry.

      Exact size is a guess (100 levels * 12 bytes per entry = 1200 = 0x4B0).
    size: 0x4b0
  team_member_table:
    pos: 0x2ad598
    doc: |-
      Table with all team members, persistent information about them, and information about which ones are currently active.

      See the comments on struct team_member_table for more information.

      type: struct team_member_table
    size: 0x99a8
  disp_mode:
    pos: 0x2bad40
    type: u2
  gxi_vram_lock_id:
    pos: 0x2bad42
    type: u2
  sub_bg_ext_pltt:
    pos: 0x2bad60
    type: u4
  clr_img:
    pos: 0x2bad7c
    type: u4
  lock_notify_array:
    pos: 0x326414
    doc: |-
      Used to notify scripts waiting for a certain lock to unlock so they can resume their execution.

      1 byte per lock.
    size: 0x18
  ground_memory_arena_1:
    pos: 0x326520
    doc: |-
      This is a top-level memory arena used for some things in ground mode.

      It's used for user_flags 8, 15, and 16.

      Including the allocator metadata, this arena occupies 0x64000 bytes of space.

      type: struct mem_arena
    size: 0x1c
  loaded_attack_sprite_data:
    pos: 0x37dc2c
    doc: |-
      [Runtime] Pointer to the dynamically allocated structure relating to the currently loaded attack sprite, in dungeon mode.

      type: struct loaded_attack_sprite_data*
    type: u4
  ai_thrown_item_direction_is_used:
    pos: 0x37dc50
    doc: '[Runtime] Used in GetPossibleAiThrownItemDirections to indicate whether
      a certain direction enum value is already being used or not.'
    size: 0x8
  ai_thrown_item_probabilities:
    pos: 0x37dc58
    doc: '[Runtime] Used to store the probabilities matching the directions in THROWN_ITEM_DIRECTIONS.'
    type: u4
    repeat: expr
    repeat-expr: 8
  ai_thrown_item_directions:
    pos: 0x37dc78
    doc: '[Runtime] Used to store the directions output by GetPossibleAiThrownItemDirections.'
    type: u4
    repeat: expr
    repeat-expr: 8
  rollout_ice_ball_missed:
    pos: 0x37dce9
    doc: '[Runtime] Appears to be set to true whenever a hit from Rollout or Ice Ball
      fails to deal damage.'
    size: 0x1
  multihit_fatigue_move_used:
    pos: 0x37dcea
    doc: '[Runtime] Appears to be set to true whenever a multihit fatigue move deals
      damage.'
    size: 0x1
  twineedle_hit_tracker:
    pos: 0x37dceb
    doc: '[Runtime] Appears to be set to true whenever Twineedle hits and deals damage.
      So that even if the second attack misses, it will still try to poison the target.'
    size: 0x1
  rapid_spin_binding_removal:
    pos: 0x37dced
    doc: '[Runtime] Appears to be set to true when using Rapid Spin to later remove
      any binding effects and Leech Seed.'
    size: 0x1
  rollout_ice_ball_successive_hits:
    pos: 0x37dcf0
    doc: '[Runtime] Seems to count the number of successive hits by Rollout or Ice
      Ball.'
    type: s4
  multihit_move_successive_hits:
    pos: 0x37dcf8
    doc: '[Runtime] Seems to count the number of successive hits for multihit moves.
      This is used by Twineedle to check to attempt to apply Poison after the second
      attack.'
    type: s4
  triple_kick_successive_hits:
    pos: 0x37dcfc
    doc: '[Runtime] Seems to count the number of successive hits by Triple Kick.'
    type: s4
  metronome_next_index:
    pos: 0x37dd08
    doc: '[Runtime] The index into METRONOME_TABLE for the next usage of Metronome.'
    type: s4
  floor_generation_status:
    pos: 0x37e23c
    doc: |-
      [Runtime] Status data related to generation of the current floor in a dungeon.

      This data is populated as the dungeon floor is generated.

      type: struct floor_generation_status
    size: 0x40
types: {}
enums: {}
