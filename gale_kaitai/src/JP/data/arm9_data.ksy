meta:
  id: arm9_data
  endian: le
instances:
  secure:
    pos: 0x0
    doc: The header of the DS cartridge secure area. See https://problemkaputt.de/gbatek.htm#dscartridgesecurearea
    size: 0x800
  start_module_params:
    pos: 0xba0
    doc: Parameters used by the NitroSDK to read the ROM.
    type: u4
  default_memory_arena_size:
    pos: 0xe58
    doc: Length in bytes of the default memory allocation arena, 1991680.
    type: u4
  log_max_arg:
    pos: 0x2220
    doc: The maximum argument value for the Log function, 2047.
    type: s4
  max_money_carried:
    pos: 0xed80
    doc: Maximum amount of money the player can carry, 99999.
    type: u4
  max_money_stored:
    pos: 0x10720
    doc: Maximum amount of money the player can store in the Duskull Bank, 9999999.
    type: u4
  cart_removed_img_data:
    pos: 0x92dd0
    type: cart_removed_img_data_entries
    size: 0x2000
  string_debug_empty:
    pos: 0x94de4
    type: s1
    repeat: expr
    repeat-expr: 4
  string_debug_format_line_file:
    pos: 0x94de8
    type: s1
    repeat: expr
    repeat-expr: 28
  string_debug_no_prog_pos:
    pos: 0x94e04
    type: s1
    repeat: expr
    repeat-expr: 24
  string_debug_spaced_print:
    pos: 0x94e1c
    type: s1
    repeat: expr
    repeat-expr: 12
  string_debug_fatal:
    pos: 0x94e28
    type: s1
    repeat: expr
    repeat-expr: 20
  string_debug_newline:
    pos: 0x94e3c
    type: s1
    repeat: expr
    repeat-expr: 4
  string_debug_log_null:
    pos: 0x94e40
    type: s1
    repeat: expr
    repeat-expr: 8
  string_debug_string_newline:
    pos: 0x94e48
    type: s1
    repeat: expr
    repeat-expr: 4
  string_effect_effect_bin:
    pos: 0x94e4c
    type: s1
    repeat: expr
    repeat-expr: 20
  string_monster_monster_bin:
    pos: 0x94e60
    type: s1
    repeat: expr
    repeat-expr: 20
  string_balance_m_level_bin:
    pos: 0x94e74
    type: s1
    repeat: expr
    repeat-expr: 20
  string_dungeon_dungeon_bin:
    pos: 0x94e88
    type: s1
    repeat: expr
    repeat-expr: 20
  string_monster_m_attack_bin:
    pos: 0x94e9c
    type: s1
    repeat: expr
    repeat-expr: 24
  string_monster_m_ground_bin:
    pos: 0x94eb4
    type: s1
    repeat: expr
    repeat-expr: 24
  string_file_directory_init:
    pos: 0x94ecc
    type: s1
    repeat: expr
    repeat-expr: 40
  available_items_in_group_table:
    pos: 0x95028
    doc: |-
      100*0x80
      Linked to the dungeon group id

      Note: unverified, ported from Irdkwia's notes
    size: 0x3200
  arm9_unknown_table_na_2097ff8:
    pos: 0x982ec
    doc: |-
      16*0x4 (0x2+0x2)

      Note: unverified, ported from Irdkwia's notes
    size: 0x40
  kecleon_shop_item_table_lists_1:
    pos: 0x983b4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: enum item_id[4]
    size: 0x10
  kecleon_shop_item_table_lists_2:
    pos: 0x983c4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: enum item_id[4]
    size: 0x10
  exclusive_item_stat_boost_data:
    pos: 0x983dc
    doc: |-
      Contains stat boost effects for different exclusive item classes.

      Each 4-byte entry contains the boost data for (attack, defense, special attack, special defense), 1 byte each, for a specific exclusive item class, indexed according to the stat boost data index list.

      type: struct exclusive_item_stat_boost_entry[15]
    type: exclusive_item_stat_boost_entry
    repeat: expr
    repeat-expr: 15
  exclusive_item_defense_boosts:
    pos: 0x983dd
    doc: EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 1
    size: 0x39
  exclusive_item_special_attack_boosts:
    pos: 0x983de
    doc: EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 2
    size: 0x39
  exclusive_item_special_defense_boosts:
    pos: 0x983df
    doc: EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 3
    size: 0x39
  exclusive_item_effect_data:
    pos: 0x98418
    doc: |-
      Contains special effects for each exclusive item.

      Each entry is 2 bytes, with the first entry corresponding to the first exclusive item (Prism Ruff). The first byte is the exclusive item effect ID, and the second byte is an index into other data tables (related to the more generic stat boosting effects for specific monsters).

      type: struct exclusive_item_effect_entry[956]
    type: exclusive_item_effect_entry
    repeat: expr
    repeat-expr: 956
  recycle_shop_item_list:
    pos: 0x98bc0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x360
  type_specific_exclusive_items:
    pos: 0x98f20
    doc: |-
      Lists of type-specific exclusive items (silk, dust, gem, globe) for each type.

      type: struct item_id_16[17][4]
    size: 0x88
  recoil_move_list:
    pos: 0x99068
    doc: |-
      Null-terminated list of all the recoil moves, as 2-byte move IDs.

      type: struct move_id_16[11]
    size: 0x16
  punch_move_list:
    pos: 0x9907e
    doc: |-
      Null-terminated list of all the punch moves, as 2-byte move IDs.

      type: struct move_id_16[16]
    size: 0x20
  move_power_stars_table:
    pos: 0x99fc8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int[6]
    type: s4
    repeat: expr
    repeat-expr: 6
  move_accuracy_stars_table:
    pos: 0x99fe0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int[8]
    type: s4
    repeat: expr
    repeat-expr: 8
  parent_menu_default_window_params:
    pos: 0x9b7e4
    doc: |-
      Default window_params for a simple_menu created with CreateParentMenuInternal.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateParentMenuInternal.

      Additionally, width and height are 0, and will be computed in CreateParentMenuInternal.
    type: window_params
  simple_menu_default_window_params:
    pos: 0x9b7f4
    doc: |-
      Default window_params for a simple_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateSimpleMenuInternal.

      Additionally, width and height are 0, and will be computed in CreateSimpleMenuInternal.
    type: window_params
  advanced_menu_default_window_params:
    pos: 0x9b804
    doc: |-
      Default window_params for an advanced_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateAdvancedMenu.

      Additionally, width and height are 0, and will be computed in CreateAdvancedMenu.
    type: window_params
  collection_menu_default_window_params:
    pos: 0x9b814
    doc: |-
      Default window_params for a collection_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateCollectionMenu.

      Additionally, width and height are 0, and will be computed in CreateCollectionMenu.
    type: window_params
  options_menu_default_window_params:
    pos: 0x9b824
    doc: |-
      Default window_params for an options_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateOptionsMenu.

      Additionally, width and height are 0, and will be computed in CreateOptionsMenu.
    type: window_params
  debug_menu_default_window_params:
    pos: 0x9b860
    doc: |-
      Default window_params for a debug_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateDebugMenu.

      Additionally, width and height are 0, and will be computed in CreateDebugMenu.
    type: window_params
  scroll_box_default_window_params:
    pos: 0x9b870
    doc: Default window_params for a scroll_box.
    type: window_params
  dialogue_box_default_window_params:
    pos: 0x9b880
    doc: Default window_params for a dialogue_box.
    type: window_params
  portrait_box_default_window_params:
    pos: 0x9b890
    doc: |-
      Default window_params for a portrait_box.

      Note that the screen and box type are unset, and are determined in CreatePortraitBox.
    type: window_params
  text_box_default_window_params:
    pos: 0x9b8a0
    doc: Default window_params for a text_box.
    type: window_params
  area_name_box_default_window_params:
    pos: 0x9b8b0
    doc: |-
      Default window_params for an area_name_box.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateAreaNameBox.

      Additionally, width and height are 0, and will be computed in CreateAreaNameBox.
    type: window_params
  controls_chart_default_window_params:
    pos: 0x9b8cc
    doc: Default window_params for a controls_chart.
    type: window_params
  alert_box_default_window_params:
    pos: 0x9b8e8
    doc: Default window_params for an alert_box.
    type: window_params
  advanced_text_box_default_window_params:
    pos: 0x9b8f8
    doc: |-
      Default window_params for an advanced_text_box.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateAdvancedTextBoxInternal.
    type: window_params
  team_selection_menu_default_window_params:
    pos: 0x9b908
    doc: |-
      Default window_params for a team_selection_menu.

      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateTeamSelectionMenu.

      Additionally, width and height are 0, and will be computed in CreateTeamSelectionMenu.
    type: window_params
  partner_talk_kind_table:
    pos: 0x9e0b8
    doc: |-
      Table of values for the PARTNER_TALK_KIND script variable.

      type: struct partner_talk_kind_table_entry[11]
    type: partner_talk_kind_table_entry
    repeat: expr
    repeat-expr: 11
  script_vars_locals:
    pos: 0x9e2a0
    doc: |-
      List of special "local" variables available to the script engine. There are 4 16-byte entries.

      Each entry has the same structure as an entry in SCRIPT_VARS.

      type: struct script_local_var_table
    type: script_local_var_table
  script_vars:
    pos: 0x9ec44
    doc: |-
      List of predefined global variables that track game state, which are available to the script engine. There are 115 16-byte entries.

      These variables underpin the various ExplorerScript global variables you can use in the SkyTemple SSB debugger.

      type: struct script_var_table
    type: script_var_table
  portrait_layouts:
    pos: 0x9f3e8
    doc: |-
      All the possible layouts a portrait can be placed in by default.

      type: struct portrait_layout[32]
    type: portrait_layout
    repeat: expr
    repeat-expr: 32
  kaomado_filepath:
    pos: 0x9f4a8
    doc: |-
      "Path of the file where all the portraits are stored. \"FONT/kaomado.kao\", padded with null to a multiple of 4"

      type: char[20]
    type: s1
    repeat: expr
    repeat-expr: 20
  wonder_mail_bits_map:
    pos: 0x9f4bc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: uint8_t[32]
    type: u1
    repeat: expr
    repeat-expr: 32
  wonder_mail_bits_swap:
    pos: 0x9f4dc
    doc: |-
      Last 2 bytes are unused

      Note: unverified, ported from Irdkwia's notes

      type: uint8_t[36]
    type: u1
    repeat: expr
    repeat-expr: 36
  arm9_unknown_table_na_209e12c:
    pos: 0x9f500
    doc: |-
      52*0x2 + 2 bytes unused

      Note: unverified, ported from Irdkwia's notes
    size: 0x38
  arm9_unknown_table_na_209e164:
    pos: 0x9f538
    doc: |-
      256*0x1

      Note: unverified, ported from Irdkwia's notes
    size: 0x100
  arm9_unknown_table_na_209e280:
    pos: 0x9f654
    doc: |-
      32*0x1

      Note: unverified, ported from Irdkwia's notes
    size: 0x20
  wonder_mail_encryption_table:
    pos: 0x9f674
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: uint8_t[256]
    type: u1
    repeat: expr
    repeat-expr: 256
  dungeon_data_list:
    pos: 0x9f774
    doc: |-
      Data about every dungeon in the game.

      This is an array of 180 dungeon data list entry structs. Each entry is 4 bytes, and contains floor count information along with an index into the bulk of the dungeon's data in mappa_s.bin.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct dungeon_data_list_entry[180]
    type: dungeon_data_list_entry
    repeat: expr
    repeat-expr: 180
  adventure_log_encounters_monster_ids:
    pos: 0x9fa44
    doc: |-
      List of monster IDs with a corresponding milestone in the Adventure Log.

      type: struct monster_id_16[38]
    size: 0x4c
  arm9_unknown_data_na_209e6bc:
    pos: 0x9fa90
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  tactic_name_string_ids:
    pos: 0x9fa94
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[12]
    type: s2
    repeat: expr
    repeat-expr: 12
  status_name_string_ids:
    pos: 0x9faac
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[102]
    type: s2
    repeat: expr
    repeat-expr: 102
  dungeon_return_status_table:
    pos: 0x9fb78
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct dungeon_return_status[91]
    type: dungeon_return_status
    repeat: expr
    repeat-expr: 91
  statuses_full_description_string_ids:
    pos: 0x9fce4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct status_description[103]
    type: status_description
    repeat: expr
    repeat-expr: 103
  arm9_unknown_data_na_209eaac:
    pos: 0x9fe80
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  mission_floor_ranks_and_item_lists_1:
    pos: 0x9fe84
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc64
  mission_floors_forbidden:
    pos: 0xa0ae8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct mission_floors_forbidden[100]
    type: mission_floors_forbidden
    repeat: expr
    repeat-expr: 100
  mission_floor_ranks_and_item_lists_2:
    pos: 0xa0bb0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x12f8
  mission_floor_ranks_ptrs:
    pos: 0xa1ea8
    doc: |-
      Uses MISSION_FLOOR_RANKS_AND_ITEM_LISTS

      Note: unverified, ported from Irdkwia's notes
    type: u4
    repeat: expr
    repeat-expr: 100
  dungeon_restrictions:
    pos: 0xa2038
    doc: |-
      Data related to dungeon restrictions for every dungeon in the game.

      This is an array of 256 dungeon restriction structs. Each entry is 12 bytes, and contains information about restrictions within the given dungeon.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct dungeon_restriction[256]
    type: dungeon_restriction
    repeat: expr
    repeat-expr: 256
  special_band_stat_boost:
    pos: 0xa2c40
    doc: Stat boost value for the Special Band.
    type: s2
  unknown_pp_boost_amount:
    pos: 0xa2c48
    doc: PP boost value for an unknown effect. Corresponds to the flag f_unknown_pp_boost
      in struct move.
    type: s2
  munch_belt_stat_boost:
    pos: 0xa2c50
    doc: Stat boost value for the Munch Belt.
    type: s2
  gummi_stat_boost:
    pos: 0xa2c5c
    doc: Stat boost value if a stat boost occurs when eating normal Gummis.
    type: s2
  min_iq_exclusive_move_user:
    pos: 0xa2c60
    doc: Minimum IQ required for enemies to use Exclusive-Move User
    type: s4
  wonder_gummi_iq_gain:
    pos: 0xa2c64
    doc: IQ gain when ingesting wonder gummis.
    type: s2
  aura_bow_stat_boost:
    pos: 0xa2c6c
    doc: Stat boost value for the aura bows.
    type: s2
  multitalent_pp_boost_amount:
    pos: 0xa2c74
    doc: PP boost value for the Multitalent IQ skill.
    type: s2
  min_iq_item_master:
    pos: 0xa2c78
    doc: Minimum IQ required for enemies to use Item Master
    type: s4
  def_scarf_stat_boost:
    pos: 0xa2c7c
    doc: Stat boost value for the Defense Scarf.
    type: s2
  power_band_stat_boost:
    pos: 0xa2c80
    doc: Stat boost value for the Power Band.
    type: s2
  wonder_gummi_stat_boost:
    pos: 0xa2c84
    doc: Stat boost value if a stat boost occurs when eating Wonder Gummis.
    type: s2
  zinc_band_stat_boost:
    pos: 0xa2c88
    doc: Stat boost value for the Zinc Band.
    type: s2
  egg_hp_bonus:
    pos: 0xa2c8c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: s2
  evolution_hp_bonus:
    pos: 0xa2c98
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: s2
  exclusive_item_pp_boost_amount:
    pos: 0xa2c9c
    doc: PP boost value for exclusive items that boost move PP.
    type: s2
  damage_formula_flv_shift:
    pos: 0xa2ca0
    doc: The constant shift added to the "FLV" intermediate quantity in the damage
      formula (see dungeon::last_move_damage_calc_flv), as a binary fixed-point number
      with 8 fraction bits (50).
    type: s4
  evolution_physical_stat_bonuses:
    pos: 0xa2ca4
    doc: |-
      0x2: Atk + 0x2: Def

      Note: unverified, ported from Irdkwia's notes
    type: s2
    repeat: expr
    repeat-expr: 2
  damage_formula_constant_shift:
    pos: 0xa2ca8
    doc: |-
      The constant shift applied to the overall output of the "unshifted base" damage formula (the sum of the scaled AT, DEF, and ClampedLn terms), as a binary fixed-point number with 8 fraction bits (-311).

      The value of -311 is notably equal to -round[DAMAGE_FORMULA_LN_PREFACTOR * ln(DAMAGE_FORMULA_LN_ARG_PREFACTOR * DAMAGE_FORMULA_FLV_SHIFT)]. This is probably not a coincidence.
    type: s4
  damage_formula_flv_deficit_divisor:
    pos: 0xa2cac
    doc: The divisor of the (AT - DEF) term within the "FLV" intermediate quantity
      in the damage formula (see dungeon::last_move_damage_calc_flv), as a binary
      fixed-point number with 8 fraction bits (8).
    type: s4
  egg_stat_bonuses:
    pos: 0xa2cb0
    doc: |-
      0x2: Atk + 0x2: SpAtk + 0x2: Def + 0x2: SpDef

      Note: unverified, ported from Irdkwia's notes
    type: s2
    repeat: expr
    repeat-expr: 4
  evolution_special_stat_bonuses:
    pos: 0xa2cb8
    doc: |-
      0x2: SpAtk + 0x2: SpDef

      Note: unverified, ported from Irdkwia's notes
    type: s2
    repeat: expr
    repeat-expr: 2
  damage_formula_non_team_member_modifier:
    pos: 0xa2cbc
    doc: The divisor applied to the overall output of the "shifted base" damage formula
      (the sum of the scaled AT, Def, ClampedLn, and DAMAGE_FORMULA_CONSTANT_SHIFT
      terms) if the attacker is not a team member (and the current fixed room is not
      the substitute room...for some reason), as a binary fixed-point number with
      8 fraction bits (85/64).
    type: s4
  damage_formula_ln_prefactor:
    pos: 0xa2cc0
    doc: The prefactor to the output of the ClampedLn in the damage formula, as a
      binary fixed-point number with 8 fraction bits (50).
    type: s4
  damage_formula_def_prefactor:
    pos: 0xa2cc4
    doc: The prefactor to the "DEF" (defense) intermediate quantity in the damage
      formula (see dungeon::last_move_damage_calc_def), as a binary fixed-point number
      with 8 fraction bits (-0.5).
    type: s4
  damage_formula_at_prefactor:
    pos: 0xa2cc8
    doc: The prefactor to the "AT" (attack) intermediate quantity in the damage formula
      (see dungeon::last_move_damage_calc_at), as a binary fixed-point number with
      8 fraction bits (153/256, which is close to 0.6).
    type: s4
  damage_formula_ln_arg_prefactor:
    pos: 0xa2ccc
    doc: The prefactor to the argument of ClampedLn in the damage formula (FLV + DAMAGE_FORMULA_FLV_SHIFT),
      as a binary fixed-point number with 8 fraction bits (10).
    type: s4
  forbidden_forgot_move_list:
    pos: 0xa2cec
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct forbidden_forgot_move_entry[3]
    type: forbidden_forgot_move_entry
    repeat: expr
    repeat-expr: 3
  tactics_unlock_level_table:
    pos: 0xa2d14
    doc: 'type: int16_t[12]'
    type: s2
    repeat: expr
    repeat-expr: 12
  client_level_table:
    pos: 0xa2d4c
    doc: |-
      Still a guess

      Note: unverified, ported from Irdkwia's notes

      type: int16_t[16]
    type: s2
    repeat: expr
    repeat-expr: 16
  outlaw_level_table:
    pos: 0xa2d6c
    doc: |-
      Table of 2-byte outlaw levels for outlaw missions, indexed by mission rank.

      type: int16_t[16]
    type: s2
    repeat: expr
    repeat-expr: 16
  outlaw_minion_level_table:
    pos: 0xa2d8c
    doc: |-
      Table of 2-byte outlaw minion levels for outlaw hideout missions, indexed by mission rank.

      type: int16_t[16]
    type: s2
    repeat: expr
    repeat-expr: 16
  hidden_power_base_power_table:
    pos: 0xa2dac
    doc: |-
      Still a guess

      Note: unverified, ported from Irdkwia's notes

      type: int[10]
    type: s4
    repeat: expr
    repeat-expr: 10
  version_exclusive_monsters:
    pos: 0xa2dd4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct version_exclusive_monster[23]
    type: version_exclusive_monster
    repeat: expr
    repeat-expr: 23
  iq_skill_restrictions:
    pos: 0xa2e30
    doc: |-
      Table of 2-byte values for each IQ skill that represent a group. IQ skills in the same group can not be enabled at the same time.

      type: int16_t[69]
    type: s2
    repeat: expr
    repeat-expr: 69
  secondary_terrain_types:
    pos: 0xa2ebc
    doc: |-
      The type of secondary terrain for each dungeon in the game.

      This is an array of 200 bytes. Each byte is an enum corresponding to one dungeon.

      type: struct secondary_terrain_type_8[200]
    size: 0xc8
  sentry_duty_monster_ids:
    pos: 0xa2f84
    doc: |-
      Table of monster IDs usable in the sentry duty minigame.

      type: struct monster_id_16[102]
    size: 0xcc
  iq_skills:
    pos: 0xa3050
    doc: |-
      Table of 4-byte values for each IQ skill that represent the required IQ value to unlock a skill.

      type: int[69]
    type: s4
    repeat: expr
    repeat-expr: 69
  iq_group_skills:
    pos: 0xa3164
    doc: "Irdkwia's notes: 25*16*0x1"
    type: u1
    repeat: expr
    repeat-expr: 400
  money_quantity_table:
    pos: 0xa32f4
    doc: |-
      Table that maps money quantity codes (as recorded in, e.g., struct item) to actual amounts.

      type: int[100]
    type: s4
    repeat: expr
    repeat-expr: 100
  arm9_unknown_table_na_20a20b0:
    pos: 0xa3484
    doc: |-
      256*0x2

      Note: unverified, ported from Irdkwia's notes
    size: 0x200
  iq_gummi_gain_table:
    pos: 0xa3684
    doc: 'type: int16_t[18][18]'
    type: s2
    repeat: expr
    repeat-expr: 18
  gummi_belly_restore_table:
    pos: 0xa390c
    doc: 'type: int16_t[18][18]'
    type: s2
    repeat: expr
    repeat-expr: 18
  bag_capacity_table_special_episodes:
    pos: 0xa3b94
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: uint32_t[5]
    type: u4
    repeat: expr
    repeat-expr: 5
  bag_capacity_table:
    pos: 0xa3ba8
    doc: |-
      Array of 4-byte integers containing the bag capacity for each bag level.

      type: uint32_t[8]
    type: u4
    repeat: expr
    repeat-expr: 8
  special_episode_main_characters:
    pos: 0xa3bc8
    doc: 'type: struct monster_id_16[100]'
    size: 0xc8
  guest_monster_data:
    pos: 0xa3c90
    doc: |-
      Data for guest monsters that join you during certain story dungeons.

      Array of 18 36-byte entries.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct guest_monster[18]
    type: guest_monster
    repeat: expr
    repeat-expr: 18
  rank_up_table:
    pos: 0xa3f18
    type: rankup_table_entry
    repeat: expr
    repeat-expr: 13
  ds_download_teams:
    pos: 0xa3fe8
    doc: |-
      Seems like this is just a collection of null-terminated lists concatenated together.

      Note: unverified, ported from Irdkwia's notes

      struct monster_id_16[56]
    size: 0x70
  arm9_unknown_ptr_na_20a2c84:
    pos: 0xa4058
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  unown_species_additional_chars:
    pos: 0xa405c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: enum monster_id[28]
    size: 0x80
  monster_sprite_data:
    pos: 0xa40dc
    doc: Contains information about the sprite size and sprite file size of each monster
    type: monster_sprite_data_entry
    repeat: expr
    repeat-expr: 600
  remote_strings:
    pos: 0xa4f24
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x2c
  rank_strings_1:
    pos: 0xa4f60
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x30
  mission_menu_string_ids_1:
    pos: 0xa4f50
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[8]
    type: s2
    repeat: expr
    repeat-expr: 8
  rank_strings_2:
    pos: 0xa4f90
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x30
  mission_menu_string_ids_2:
    pos: 0xa4fc0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[8]
    type: s2
    repeat: expr
    repeat-expr: 8
  rank_strings_3:
    pos: 0xa4fd0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xb4
  mission_dungeon_unlock_table:
    pos: 0xa5090
    doc: |-
      Irdkwia's notes: SpecialDungeonMissions

      type: struct dungeon_unlock_entry[3]
    type: dungeon_unlock_entry
    repeat: expr
    repeat-expr: 3
  no_send_item_table:
    pos: 0xa5096
    doc: |-
      A list of items that are forbidden from being used in a mission sent by Wonder Mail.

      type: struct item_id_16[3]
    size: 0x6
  arm9_unknown_table_na_20a3cc8:
    pos: 0xa50ac
    doc: |-
      14*0x2
      Linked to ARM9_UNKNOWN_TABLE__NA_20A3CE4

      Note: unverified, ported from Irdkwia's notes
    size: 0x1c
  arm9_unknown_table_na_20a3ce4:
    pos: 0xa50c8
    doc: |-
      8*0x2

      Note: unverified, ported from Irdkwia's notes
    size: 0x10
  arm9_unknown_function_table_na_20a3cf4:
    pos: 0xa50d8
    doc: |-
      Could be related to missions

      Note: unverified, ported from Irdkwia's notes
    size: 0x20
  mission_banned_story_monsters:
    pos: 0xa50f8
    doc: |-
      Null-terminated list of monster IDs that can't be used (probably as clients or targets) when generating missions before a certain point in the story.

      To be precise, PERFOMANCE_PROGRESS_FLAG[9] must be enabled so these monsters can appear as mission clients.

      type: struct monster_id_16[length / 2]
    size: 0x2a
  item_delivery_table:
    pos: 0xa5122
    doc: |-
      A list of valid items used for delivering an item for a mission client.

      type: struct item_id_16[23]
    size: 0x2e
  mission_rank_points:
    pos: 0xa5150
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int[16]
    type: s4
    repeat: expr
    repeat-expr: 16
  mission_banned_monsters:
    pos: 0xa5190
    doc: |-
      Null-terminated list of monster IDs that can't be used (probably as clients or targets) when generating missions.

      type: struct monster_id_16[124]
    size: 0xf8
  mission_string_ids:
    pos: 0xa5288
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[964]
    type: s2
    repeat: expr
    repeat-expr: 964
  level_list:
    pos: 0xa5ad0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x2234
  events:
    pos: 0xa6894
    doc: |-
      Table of levels for the script engine, in which scenes can take place. There are a version-dependent number of 12-byte entries.

      type: struct script_level[length / 12]
    type: events_entries
    size: 0x1470
  arm9_unknown_table_na_20a68bc:
    pos: 0xa7d04
    doc: |-
      6*0x2

      Note: unverified, ported from Irdkwia's notes
    size: 0xc
  demo_teams:
    pos: 0xa7d10
    doc: |-
      18*0x4 (Hero ID 0x2, Partner ID 0x2)

      Note: unverified, ported from Irdkwia's notes
    size: 0x48
  actor_list:
    pos: 0xa7d58
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x28f8
  entities:
    pos: 0xa9438
    doc: |-
      Table of entities for the script engine, which can move around and do things within a scene. There are 386 12-byte entries.

      type: struct script_entity[386]
    type: script_entity
    repeat: expr
    repeat-expr: 386
  job_window_params_1:
    pos: 0xaa660
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  job_menu_items_1:
    pos: 0xaa670
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  job_menu_items_2:
    pos: 0xaa690
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  job_menu_items_3:
    pos: 0xaa700
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  job_menu_items_4:
    pos: 0xaa718
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  job_menu_items_5:
    pos: 0xaa730
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  job_menu_items_6:
    pos: 0xaa748
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  job_menu_items_7:
    pos: 0xaa760
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  job_menu_items_8:
    pos: 0xaa778
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  job_menu_items_9:
    pos: 0xaa790
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  job_menu_items_10:
    pos: 0xaa7a8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  job_menu_items_11:
    pos: 0xaa7c0
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  job_menu_items_12:
    pos: 0xaa7d8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  job_menu_items_13:
    pos: 0xaa7f8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  job_window_params_2:
    pos: 0xaa818
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  dungeon_swap_id_table:
    pos: 0xaa828
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct dungeon_id_8[212]
    size: 0xd4
  map_marker_placements:
    pos: 0xaa918
    doc: |-
      The map marker position of each dungeon on the Wonder Map.

      This is an array of 310 map marker structs. Each entry is 8 bytes, and contains positional information about a dungeon on the map.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct map_marker[310]
    type: map_marker
    repeat: expr
    repeat-expr: 310
  lfo_output_voice_update_flags:
    pos: 0xab3e8
    type: dse_voice_update_flags
  trig_table:
    pos: 0xab3f8
    doc: |-
      Interleaved table of sine and cosine values at 4096 divisions over a full period (2π radians).

      More precisely, the trig_values entry at index i corresponds to {sin(i * 2π/4096), cos(i * 2π/4096)} (each division is ~1/10 of a degree). Values are stored as signed fixed-point numbers with 12 fraction bits.

      type: struct trig_values[4096]
    type: trig_values
    repeat: expr
    repeat-expr: 4096
  fx_atan_idx_table:
    pos: 0xaf3f8
    doc: |-
      Table of arctangent values at 129 divisions over the domain [0, 1].

      More precisely, entry at index i corresponds to (atan(i/128) / (π/2)). Values are stored as signed fixed-point numbers with 14 fraction bits.
    type: s2
    repeat: expr
    repeat-expr: 129
  tex_pltt_start_addr_table:
    pos: 0xaf4fc
    type: s2
    repeat: expr
    repeat-expr: 8
  tex_start_addr_table:
    pos: 0xaf50c
    type: s2
    repeat: expr
    repeat-expr: 48
  arm9_unknown_table_na_20ae924:
    pos: 0xafd6c
    doc: |-
      724*0x1

      Note: unverified, ported from Irdkwia's notes
    size: 0x2d4
  memory_allocation_arena_getters:
    pos: 0xb0340
    doc: |-
      Functions to get the desired memory arena for allocating and freeing heap memory.

      type: struct mem_arena_getters
    type: mem_arena_getters
  prng_sequence_num:
    pos: 0xb036c
    doc: '[Runtime] The current PRNG sequence number for the general-purpose PRNG.
      See Rand16Bit for more information on how the general-purpose PRNG works.'
    type: u2
  loaded_overlay_group_1:
    pos: 0xb0674
    doc: |-
      [Runtime] The overlay group ID of the overlay currently loaded in slot 1. A group ID of 0 denotes no overlay.

      Overlay group IDs that can be loaded in slot 1:
      - 0x4 (overlay 1)
      - 0x5 (overlay 2)
      - 0xD (overlay 11)
      - 0xE (overlay 29)
      - 0xF (overlay 34)

      type: enum overlay_group_id
    size: 0x4
  pack_files_opened:
    pos: 0xb0adc
    doc: |-
      [Runtime] A pointer to the 6 opened Pack files (listed at PACK_FILE_PATHS_TABLE)

      type: struct pack_file_opened*
    type: u4
  bag_items_ptr_mirror:
    pos: 0xb0af8
    doc: |-
      [Runtime] Probably a mirror of ram.yml::BAG_ITEMS_PTR?

      Note: unverified, ported from Irdkwia's notes
    type: u4
  item_data_table_ptrs:
    pos: 0xb0b00
    doc: |-
      [Runtime] List of pointers to various item data tables.

      The first two pointers are definitely item-related (although the order appears to be flipped between EU/NA?). Not sure about the third pointer.
    type: u4
    repeat: expr
    repeat-expr: 3
  wan_table:
    pos: 0xb10a8
    doc: |-
      pointer to the list of wan sprite loaded in RAM

      struct wan_table*
    type: u4
  render_3d:
    pos: 0xb10c0
    doc: |-
      The (seemingly) unique instance render_3d_global in the game

      type: struct render_3d_global
    type: render_3d_global
  tbl_talk_group_string_id_start:
    pos: 0xb1140
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[6]
    type: s2
    repeat: expr
    repeat-expr: 6
  keyboard_string_ids:
    pos: 0xb1240
    doc: |-
      30*0x2

      Note: unverified, ported from Irdkwia's notes

      type: int16_t[30]
    type: s2
    repeat: expr
    repeat-expr: 30
  notify_note:
    pos: 0xb176c
    doc: |-
      [Runtime] Flag related to saving and loading state?

      type: bool
    size: 0x1
  default_hero_id:
    pos: 0xb1770
    doc: |-
      The default monster ID for the hero (0x4: Charmander)

      type: struct monster_id_16
    size: 0x2
  default_partner_id:
    pos: 0xb1772
    doc: |-
      The default monster ID for the partner (0x1: Bulbasaur)

      type: struct monster_id_16
    size: 0x2
  game_mode:
    pos: 0xb17e4
    doc: |-
      [Runtime] Game mode, see enum game_mode for possible values.

      type: uint8_t
    type: u1
  global_progress_ptr:
    pos: 0xb17e8
    doc: |-
      [Runtime]

      type: struct global_progress*
    type: u4
  adventure_log_ptr:
    pos: 0xb17ec
    doc: |-
      [Runtime]

      type: struct adventure_log*
    type: u4
  item_tables_ptrs_1:
    pos: 0xb21bc
    doc: "Irdkwia's notes: 26*0x4, uses MISSION_FLOOR_RANKS_AND_ITEM_LISTS"
    type: u4
    repeat: expr
    repeat-expr: 26
  unown_species_additional_char_ptr_table:
    pos: 0xb224c
    doc: |-
      Uses UNOWN_SPECIES_ADDITIONAL_CHARS

      Note: unverified, ported from Irdkwia's notes

      type: enum monster_id*[28]
    size: 0x70
  team_member_table_ptr:
    pos: 0xb22bc
    doc: Pointer to TEAM_MEMBER_TABLE
    type: u4
  mission_deliver_list_ptr:
    pos: 0xb22d4
    doc: A pointer to a heap-allocated list of items usable for delivery missions
    type: u4
  mission_deliver_count:
    pos: 0xb22d8
    doc: The total number of items usable for delivery missions
    type: s4
  mission_dungeon_list_ptr:
    pos: 0xb22dc
    doc: A pointer to a heap-allocated list of dungeons usable for missions
    type: u4
  mission_dungeon_count:
    pos: 0xb22e0
    doc: The total number of dungeons usable for missions
    type: s4
  mission_monster_list_ptr:
    pos: 0xb22e4
    doc: A pointer to a heap-allocated list of monsters usable for missions
    type: u4
  mission_monster_count:
    pos: 0xb22e8
    doc: The total number of monsters usable for missions
    type: s4
  mission_list_ptr:
    pos: 0xb22ec
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: u4
  remote_string_ptr_table:
    pos: 0xb22f0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: const char*[7]
    size: 0x1c
  rank_string_ptr_table:
    pos: 0xb230c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: const char*[16]
    size: 0x40
  smd_events_fun_table:
    pos: 0xb2404
    doc: |-
      Table of all DSE events, see https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/

      Irdkwia's notes: named DSEEventFunctionPtrTable with length 0x3C0 (note the disagreement), 240*0x4.
    type: u4
    repeat: expr
    repeat-expr: 127
  music_duration_lookup_table_1:
    pos: 0xb27c4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[128]
    type: s2
    repeat: expr
    repeat-expr: 128
  music_duration_lookup_table_2:
    pos: 0xb28c4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int32_t[128]
    type: s4
    repeat: expr
    repeat-expr: 128
  gxi_dma_id:
    pos: 0xb440c
    type: u4
types:
  exclusive_item_stat_boost_entry:
  - id: atk
    type: s1
  - id: def
    type: s1
  - id: sp_atk
    type: s1
  - id: sp_def
    type: s1
  exclusive_item_effect_entry:
  - id: effect_id
    type: exclusive_item_effect_id_8
  - id: foreign_idx
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
  partner_talk_kind_table_entry:
  - id: talk_kind
    type: talk_kind
  - id: id
    type: monster_id
  script_local_var_table: []
  script_var_table: []
  portrait_layout:
  - id: offset_x
    type: s2
  - id: offset_y
    type: s2
  - id: try_flip
    type: bool
  - id: _padding
    type: u1
  dungeon_data_list_entry:
  - id: n_floors
    type: u1
  - id: dungeon_data_index_mappa_s
    type: u1
  - id: n_preceding_floors_group
    type: u1
  - id: n_total_floors_group
    type: u1
  dungeon_return_status:
  - id: flag
    type: bool
  - id: _padding
    type: u1
  - id: string_id
    type: s2
  status_description:
  - id: name_str_id
    type: s2
  - id: desc_str_id
    type: s2
  mission_floors_forbidden:
  - id: field_0x0
    type: u1
  - id: field_0x1
    type: u1
  dungeon_restriction:
  - id: unused
    type: u2
  - id: max_rescue_attempts
    type: u1
  - id: max_items_allowed
    type: u1
  - id: max_party_size
    type: u1
  - id: field_0x7
    type: u1
  - id: turn_limit_per_floor
    type: u2
  - id: random_movement_chance
    type: s2
  forbidden_forgot_move_entry:
  - id: monster_id
    type: monster_id_16
  - id: origin_id
    type: dungeon_id_16
  - id: move_id
    type: move_id_16
  version_exclusive_monster:
  - id: id
    type: monster_id_16
  - id: in_eot
    type: bool
  - id: in_eod
    type: bool
  guest_monster:
  - id: id
    type: monster_id_16
  - id: joined_at
    type: dungeon_id_8
  - id: joined_at_floor
    type: u1
  - id: max_hp
    type: s2
  - id: level
    type: u1
  - id: field_0x13
    type: u1
  - id: iq
    type: s2
  - id: atk
    type: u1
  - id: field_0x17
    type: u1
  - id: sp_atk
    type: u1
  - id: field_0x19
    type: u1
  - id: def
    type: u1
  - id: field_0x1b
    type: u1
  - id: sp_def
    type: u1
  - id: field_0x1d
    type: u1
  - id: field_0x1e
    type: u1
  - id: field_0x1f
    type: u1
  - id: exp
    type: s4
  rankup_table_entry:
  - id: field_0x0
    type: u1
  - id: field_0x1
    type: u1
  - id: field_0x2
    type: u1
  - id: field_0x3
    type: u1
  - id: field_0x4
    type: s4
  - id: field_0x8
    type: s4
  - id: field_0xc
    type: s2
  - id: field_0xe
    type: u1
  - id: field_0xf
    type: u1
  monster_sprite_data_entry:
  - id: sprite_size
    type: u1
  - id: sprite_file_size
    type: u1
  dungeon_unlock_entry:
  - id: dungeon_id
    type: dungeon_id_8
  - id: scenario_balance_min
    type: u1
  script_level:
  - id: mapty
    type: u2
  - id: field_0x2
    type: u2
  - id: mapid
    type: u2
  - id: weather_id
    type: u2
  script_entity:
  - id: type
    type: u2
  - id: entid
    type: u2
  - id: field_0x8
    type: u2
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  simple_menu_id_item:
  - id: string_id
    type: u2
  - id: _padding
    type: u2
  - id: result_value
    type: s4
  map_marker:
  - id: map_id
    type: u2
  - id: reference_id
    type: s2
  - id: pos
    type: position
  dse_voice_update_flags: []
  trig_values:
  - id: sin
    type: fx16_12
  - id: cos
    type: fx16_12
  mem_arena_getters:
  - id: get_alloc_arena
    type: get_alloc_arena_fn_t
  - id: get_free_arena
    type: get_free_arena_fn_t
  render_3d_global:
  - id: current_index
    type: s2
  - id: max_index
    type: s2
  - id: palette_base_addr
    type: s4
  - id: texture_vram_offset
    type: s4
  - id: field4_0xc
    type: u1
  - id: field5_0xd
    type: u1
  - id: field6_0xe
    type: u1
  - id: field7_0xf
    type: u1
  - id: field8_0x10
    type: u1
  - id: field9_0x11
    type: u1
  - id: field10_0x12
    type: u1
  - id: field11_0x13
    type: u1
  - id: field12_0x14
    type: u1
  - id: field13_0x15
    type: u1
  - id: field14_0x16
    type: u1
  - id: field15_0x17
    type: u1
  - id: field16_0x18
    type: u1
  - id: field17_0x19
    type: u1
  - id: field18_0x1a
    type: u1
  - id: field19_0x1b
    type: u1
  - id: field20_0x1c
    type: u1
  - id: field21_0x1d
    type: u1
  - id: field22_0x1e
    type: u1
  - id: field23_0x1f
    type: u1
  - id: field24_0x20
    type: u1
  - id: field25_0x21
    type: u1
  - id: field26_0x22
    type: u1
  - id: field27_0x23
    type: u1
  - id: field28_0x24
    type: u1
  - id: field29_0x25
    type: u1
  - id: field30_0x26
    type: u1
  - id: field31_0x27
    type: u1
  - id: field32_0x28
    type: u1
  - id: field33_0x29
    type: u1
  - id: field34_0x2a
    type: u1
  - id: field35_0x2b
    type: u1
  - id: field36_0x2c
    type: u1
  - id: field37_0x2d
    type: u1
  - id: field38_0x2e
    type: u1
  - id: field39_0x2f
    type: u1
  - id: field40_0x30
    type: u1
  - id: field41_0x31
    type: u1
  - id: field42_0x32
    type: u1
  - id: field43_0x33
    type: u1
  - id: field44_0x34
    type: u1
  - id: field45_0x35
    type: u1
  - id: field46_0x36
    type: u1
  - id: field47_0x37
    type: u1
  - id: field48_0x38
    type: u1
  - id: field49_0x39
    type: u1
  - id: field50_0x3a
    type: u1
  - id: field51_0x3b
    type: u1
  - id: field52_0x3c
    type: u1
  - id: field53_0x3d
    type: u1
  - id: field54_0x3e
    type: u1
  - id: field55_0x3f
    type: u1
  mem_alloc_table:
  - id: n_arenas
    type: u4
  - id: default_arena
    type: mem_arena
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
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
  events_entries:
    seq:
    - id: entries
      type: script_level
      repeat: eos
enums: {}
