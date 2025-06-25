meta:
  id: overlay11_data
  endian: le
  imports:
  - ../types/script_command_parsing_data_array
  - ../types/script_op_code_names_array
  - ../types/script_opcode_table
  - ../types/overlay11_debug_strings_array
  - ../types/c_routine_names_array
  - ../types/common_routine_table
  - ../types/ground_weather_table_array
  - ../types/ground_wan_files_table_array
  - ../types/objects_array
  - ../types/recruitment_table_locations_array
  - ../types/recruitment_table_levels_array
  - ../types/recruitment_table_species_array
  - ../types/level_tilemap_list_array
  - ../types/ground_entity_function_table
  - ../types/setanimation_table_array
  - ../types/ground_entity_function_table
  - ../types/ground_entity_function_table
  - ../types/window_params
  - ../types/overlay11_overlay_load_table_array
  - ../types/main_ground_data
instances:
  script_command_parsing_data:
    pos: 0x3a75c
    type: script_command_parsing_data_array
    doc: Used by ScriptCommandParsing somehow
  script_op_code_names:
    pos: 0x3a77c
    type: script_op_code_names_array
    doc: Opcode name strings pointed to by entries in SCRIPT_OP_CODES 
      (script_opcode::name)
  script_op_codes:
    pos: 0x3c294
    type: script_opcode_table
    doc: |-
      Table of opcodes for the script engine. There are 383 8-byte entries.

      These opcodes underpin the various ExplorerScript functions you can call in the SkyTemple SSB debugger.

      type: struct script_opcode_table
  overlay11_debug_strings:
    pos: 0x3ce8c
    type: overlay11_debug_strings_array
    doc: Strings used with various debug printing functions throughout the 
      overlay
  c_routine_names:
    pos: 0x3d770
    type: c_routine_names_array
    doc: Common routine name strings pointed to by entries in C_ROUTINES 
      (common_routine::name)
  c_routines:
    pos: 0x404ac
    type: common_routine_table
    doc: |-
      Common routines used within the unionall.ssb script (the master script). There are 701 8-byte entries.

      These routines underpin the ExplorerScript coroutines you can call in the SkyTemple SSB debugger.

      type: struct common_routine_table
  ground_weather_table:
    pos: 0x41a94
    type: ground_weather_table_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct ground_weather_entry[12]
  ground_wan_files_table:
    pos: 0x41ac4
    type: ground_wan_files_table_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: char[343][12]
  objects:
    pos: 0x42ad8
    type: objects_array
    doc: |-
      Table of objects for the script engine, which can be placed in scenes. There are a version-dependent number of 12-byte entries.

      type: struct script_object[length / 12]
  recruitment_table_locations:
    pos: 0x44518
    type: recruitment_table_locations_array
    doc: |-
      Table of dungeon IDs corresponding to entries in RECRUITMENT_TABLE_SPECIES.

      type: struct dungeon_id_16[22]
  recruitment_table_levels:
    pos: 0x44530
    type: recruitment_table_levels_array
    doc: |-
      Table of levels for recruited Pokémon, corresponding to entries in RECRUITMENT_TABLE_SPECIES.

      type: int16_t[22]
  recruitment_table_species:
    pos: 0x4455c
    type: recruitment_table_species_array
    doc: |-
      Table of Pokémon recruited at special locations, such as at the ends of certain dungeons (e.g., Dialga or the Seven Treasures legendaries) or during a cutscene (e.g., Cresselia and Manaphy).

      Interestingly, this includes both Heatran genders. It also includes Darkrai for some reason?

      type: struct monster_id_16[22]
  level_tilemap_list:
    pos: 0x449b0
    type: level_tilemap_list_array
    doc: |-
      Irdkwia's notes: FIXED_FLOOR_GROUND_ASSOCIATION

      type: struct level_tilemap_list_entry[81]
  actor_function_table:
    pos: 0x45500
    type: ground_entity_function_table
    doc: A function pointer table accessed when performing script opcodes on 
      actors.
  setanimation_table:
    pos: 0x45550
    type: setanimation_table_array
    doc: |-
      Table that associates the parameter of the SetAnimation scripting opcode to animation data.

      The first entry is unused and has a value of 0xFFFF.
  object_function_table:
    pos: 0x45a80
    type: ground_entity_function_table
    doc: A function pointer table accessed when performing script opcodes on 
      objects.
  performer_function_table:
    pos: 0x45d94
    type: ground_entity_function_table
    doc: A function pointer table accessed when performing script opcodes on 
      performers.
  team_info_box_default_window_params:
    pos: 0x460e0
    type: window_params
    doc: Default window_params for a team_info_box.
  overlay11_overlay_load_table:
    pos: 0x46d08
    type: overlay11_overlay_load_table_array
    doc: |-
      The overlays that can be loaded while this one is loaded.

      Each entry is 16 bytes, consisting of:
      - overlay group ID (see arm9.yml or enum overlay_group_id in the C headers for a mapping between group ID and overlay number)
      - function pointer to entry point
      - function pointer to destructor
      - possibly function pointer to frame-update function?

      type: struct overlay_load_entry[21]
  ground_state_ptrs:
    pos: 0x48974
    type: main_ground_data
    doc: |-
      Host pointers to multiple structure used for performing an overworld scene

      type: struct main_ground_data
  world_map_mode:
    pos: 0x48a64
    type: u4
    doc: The current world map
