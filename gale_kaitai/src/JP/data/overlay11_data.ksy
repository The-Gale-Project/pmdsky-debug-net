meta:
  id: overlay11_data
  endian: le
instances:
  script_command_parsing_data:
    pos: 0x3a75c
    doc: Used by ScriptCommandParsing somehow
    type: u1
    repeat: expr
    repeat-expr: 32
  script_op_codes:
    pos: 0x3c294
    doc: |-
      Table of opcodes for the script engine. There are 383 8-byte entries.

      These opcodes underpin the various ExplorerScript functions you can call in the SkyTemple SSB debugger.

      type: struct script_opcode_table
    size: 0xbf8
  c_routines:
    pos: 0x404ac
    doc: |-
      Common routines used within the unionall.ssb script (the master script). There are 701 8-byte entries.

      These routines underpin the ExplorerScript coroutines you can call in the SkyTemple SSB debugger.

      type: struct common_routine_table
    size: 0x15e8
  ground_wan_files_table:
    pos: 0x41ac4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: char[343][12]
    type: s1
    repeat: expr
    repeat-expr: 343
  objects:
    pos: 0x42ad8
    doc: |-
      Table of objects for the script engine, which can be placed in scenes. There are a version-dependent number of 12-byte entries.

      type: struct script_object[length / 12]
    size: 0x1a04
  recruitment_table_locations:
    pos: 0x44518
    doc: |-
      Table of dungeon IDs corresponding to entries in RECRUITMENT_TABLE_SPECIES.

      type: struct dungeon_id_16[22]
    size: 0x16
  recruitment_table_levels:
    pos: 0x44530
    doc: |-
      Table of levels for recruited Pokémon, corresponding to entries in RECRUITMENT_TABLE_SPECIES.

      type: int16_t[22]
    type: s2
    repeat: expr
    repeat-expr: 22
  recruitment_table_species:
    pos: 0x4455c
    doc: |-
      Table of Pokémon recruited at special locations, such as at the ends of certain dungeons (e.g., Dialga or the Seven Treasures legendaries) or during a cutscene (e.g., Cresselia and Manaphy).

      Interestingly, this includes both Heatran genders. It also includes Darkrai for some reason?

      type: struct monster_id_16[22]
    size: 0x2c
  level_tilemap_list:
    pos: 0x449b0
    doc: |-
      Irdkwia's notes: FIXED_FLOOR_GROUND_ASSOCIATION

      type: struct level_tilemap_list_entry[81]
    size: 0x288
  actor_function_table:
    pos: 0x45500
    doc: A function pointer table accessed when performing script opcodes on actors.
    size: 0x50
  object_function_table:
    pos: 0x45a80
    doc: A function pointer table accessed when performing script opcodes on objects.
    size: 0x50
  performer_function_table:
    pos: 0x45d94
    doc: A function pointer table accessed when performing script opcodes on performers.
    size: 0x50
  ground_state_ptrs:
    pos: 0x48974
    doc: |-
      Host pointers to multiple structure used for performing an overworld scene

      type: struct main_ground_data
    size: 0x18
  world_map_mode:
    pos: 0x48a64
    doc: The current world map
    type: u4
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
  script_op_code_names_entries:
    seq:
    - id: entries
      type: s1
      repeat: eos
  overlay11_debug_strings_entries:
    seq:
    - id: entries
      type: s1
      repeat: eos
  c_routine_names_entries:
    seq:
    - id: entries
      type: s1
      repeat: eos
enums: {}
