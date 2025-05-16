meta:
  id: overlay11_data
  endian: le
instances:
  script_command_parsing_data:
    pos: 0x3a938
    doc: Used by ScriptCommandParsing somehow
    type: u1
    repeat: expr
    repeat-expr: 32
  script_op_codes:
    pos: 0x3c470
    doc: |-
      Table of opcodes for the script engine. There are 383 8-byte entries.

      These opcodes underpin the various ExplorerScript functions you can call in the SkyTemple SSB debugger.

      type: struct script_opcode_table
    type: script_opcode_table
  c_routines:
    pos: 0x40688
    doc: |-
      Common routines used within the unionall.ssb script (the master script). There are 701 8-byte entries.

      These routines underpin the ExplorerScript coroutines you can call in the SkyTemple SSB debugger.

      type: struct common_routine_table
    type: common_routine_table
  ground_weather_table:
    pos: 0x41c70
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct ground_weather_entry[12]
    type: ground_weather_entry
    repeat: expr
    repeat-expr: 12
  ground_wan_files_table:
    pos: 0x41ca0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: char[343][12]
    type: s1
    repeat: expr
    repeat-expr: 343
  objects:
    pos: 0x42d5c
    doc: |-
      Table of objects for the script engine, which can be placed in scenes. There are a version-dependent number of 12-byte entries.

      type: struct script_object[length / 12]
    type: objects_entries
    size: 0x1aac
  recruitment_table_locations:
    pos: 0x44844
    doc: |-
      Table of dungeon IDs corresponding to entries in RECRUITMENT_TABLE_SPECIES.

      type: struct dungeon_id_16[22]
    size: 0x16
  recruitment_table_levels:
    pos: 0x4485c
    doc: |-
      Table of levels for recruited Pokémon, corresponding to entries in RECRUITMENT_TABLE_SPECIES.

      type: int16_t[22]
    type: s2
    repeat: expr
    repeat-expr: 22
  recruitment_table_species:
    pos: 0x44888
    doc: |-
      Table of Pokémon recruited at special locations, such as at the ends of certain dungeons (e.g., Dialga or the Seven Treasures legendaries) or during a cutscene (e.g., Cresselia and Manaphy).

      Interestingly, this includes both Heatran genders. It also includes Darkrai for some reason?

      type: struct monster_id_16[22]
    size: 0x2c
  level_tilemap_list:
    pos: 0x44cdc
    doc: |-
      Irdkwia's notes: FIXED_FLOOR_GROUND_ASSOCIATION

      type: struct level_tilemap_list_entry[81]
    type: level_tilemap_list_entry
    repeat: expr
    repeat-expr: 81
  actor_function_table:
    pos: 0x4582c
    doc: A function pointer table accessed when performing script opcodes on actors.
    type: ground_entity_function_table
  setanimation_table:
    pos: 0x4587c
    doc: |-
      Table that associates the parameter of the SetAnimation scripting opcode to animation data.

      The first entry is unused and has a value of 0xFFFF.
    type: animation_data
    repeat: expr
    repeat-expr: 84
  object_function_table:
    pos: 0x45dac
    doc: A function pointer table accessed when performing script opcodes on objects.
    type: ground_entity_function_table
  performer_function_table:
    pos: 0x460c0
    doc: A function pointer table accessed when performing script opcodes on performers.
    type: ground_entity_function_table
  team_info_box_default_window_params:
    pos: 0x4640c
    doc: Default window_params for a team_info_box.
    type: window_params
  overlay11_overlay_load_table:
    pos: 0x4701c
    doc: |-
      The overlays that can be loaded while this one is loaded.

      Each entry is 16 bytes, consisting of:
      - overlay group ID (see arm9.yml or enum overlay_group_id in the C headers for a mapping between group ID and overlay number)
      - function pointer to entry point
      - function pointer to destructor
      - possibly function pointer to frame-update function?

      type: struct overlay_load_entry[21]
    type: overlay_load_entry
    repeat: expr
    repeat-expr: 21
  ground_state_ptrs:
    pos: 0x48cb4
    doc: |-
      Host pointers to multiple structure used for performing an overworld scene

      type: struct main_ground_data
    type: main_ground_data
  world_map_mode:
    pos: 0x48da4
    doc: The current world map
    type: u4
types:
  script_opcode_table: []
  common_routine_table: []
  ground_weather_entry:
  - id: field_0x0
    type: s2
  - id: field_0x2
    type: s2
  script_object:
  - id: field_0x0
    type: s2
  - id: field_0x2
    type: u1
  - id: field_0x3
    type: u1
  - id: field_0x8
    type: u1
  level_tilemap_list_entry:
  - id: field_0x0
    type: s2
  - id: field_0x2
    type: u1
  - id: field_0x3
    type: u1
  - id: field_0x4
    type: u4
  ground_entity_function_table:
  - id: routine_kind
    type: script_routine_kind_16
  - id: padding
    type: u2
  animation_data:
  - id: animation_id
    type: u1
  window_params:
  - id: update
    type: update_window_fn_t
  - id: x_offset
    type: u1
  - id: y_offset
    type: u1
  - id: width
    type: u1
  - id: height
    type: u1
  - id: screen
    type: screen_8
  - id: box_type
    type: box_type_8
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  overlay_load_entry:
  - id: group
    type: overlay_group_id
  main_ground_data: []
  objects_entries:
    seq:
    - id: entries
      type: script_object
      repeat: eos
enums: {}
