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
  aura_bow_id_last:
    pos: 0xccbc
    doc: Highest item ID of the aura bows.
    size: 0x4
  max_money_carried:
    pos: 0xedf8
    doc: Maximum amount of money the player can carry, 99999.
    type: u4
  max_money_stored:
    pos: 0x107f8
    doc: Maximum amount of money the player can store in the Duskull Bank, 9999999.
    type: u4
  max_play_time:
    pos: 0x51188
    doc: |-
      Maximum number of seconds that the file timer counts up to.

      35999999 seconds (one second under 10000 hours).
    type: u4
  monster_id_limit:
    pos: 0x54818
    doc: One more than the maximum valid monster ID (0x483).
    type: u4
  cart_removed_img_data:
    pos: 0x92ee4
    type: cart_removed_img_data_entries
    size: 0x2000
  string_debug_empty:
    pos: 0x94ef8
    type: s1
    repeat: expr
    repeat-expr: 4
  string_debug_format_line_file:
    pos: 0x94efc
    type: s1
    repeat: expr
    repeat-expr: 28
  string_debug_no_prog_pos:
    pos: 0x94f18
    type: s1
    repeat: expr
    repeat-expr: 24
  string_debug_spaced_print:
    pos: 0x94f30
    type: s1
    repeat: expr
    repeat-expr: 12
  string_debug_fatal:
    pos: 0x94f3c
    type: s1
    repeat: expr
    repeat-expr: 20
  string_debug_newline:
    pos: 0x94f50
    type: s1
    repeat: expr
    repeat-expr: 4
  string_debug_log_null:
    pos: 0x94f54
    type: s1
    repeat: expr
    repeat-expr: 8
  string_debug_string_newline:
    pos: 0x94f5c
    type: s1
    repeat: expr
    repeat-expr: 4
  string_effect_effect_bin:
    pos: 0x94f60
    type: s1
    repeat: expr
    repeat-expr: 20
  string_monster_monster_bin:
    pos: 0x94f74
    type: s1
    repeat: expr
    repeat-expr: 20
  string_balance_m_level_bin:
    pos: 0x94f88
    type: s1
    repeat: expr
    repeat-expr: 20
  string_dungeon_dungeon_bin:
    pos: 0x94f9c
    type: s1
    repeat: expr
    repeat-expr: 20
  string_monster_m_attack_bin:
    pos: 0x94fb0
    type: s1
    repeat: expr
    repeat-expr: 24
  string_monster_m_ground_bin:
    pos: 0x94fc8
    type: s1
    repeat: expr
    repeat-expr: 24
  string_file_directory_init:
    pos: 0x94fe0
    type: s1
    repeat: expr
    repeat-expr: 40
  available_items_in_group_table:
    pos: 0x95130
    doc: |-
      100*0x80
      Linked to the dungeon group id

      Note: unverified, ported from Irdkwia's notes
    size: 0x3200
  arm9_unknown_table_na_2097ff8:
    pos: 0x98444
    doc: |-
      16*0x4 (0x2+0x2)

      Note: unverified, ported from Irdkwia's notes
    size: 0x40
  kecleon_shop_item_table_lists_1:
    pos: 0x98504
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: enum item_id[4]
    size: 0x10
  kecleon_shop_item_table_lists_2:
    pos: 0x98514
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: enum item_id[4]
    size: 0x10
  exclusive_item_stat_boost_data:
    pos: 0x9852c
    doc: |-
      Contains stat boost effects for different exclusive item classes.

      Each 4-byte entry contains the boost data for (attack, defense, special attack, special defense), 1 byte each, for a specific exclusive item class, indexed according to the stat boost data index list.

      type: struct exclusive_item_stat_boost_entry[15]
    size: 0x3c
  exclusive_item_defense_boosts:
    pos: 0x9852d
    doc: EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 1
    size: 0x39
  exclusive_item_special_attack_boosts:
    pos: 0x9852e
    doc: EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 2
    size: 0x39
  exclusive_item_special_defense_boosts:
    pos: 0x9852f
    doc: EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 3
    size: 0x39
  exclusive_item_effect_data:
    pos: 0x98568
    doc: |-
      Contains special effects for each exclusive item.

      Each entry is 2 bytes, with the first entry corresponding to the first exclusive item (Prism Ruff). The first byte is the exclusive item effect ID, and the second byte is an index into other data tables (related to the more generic stat boosting effects for specific monsters).

      type: struct exclusive_item_effect_entry[956]
    size: 0x778
  exclusive_item_stat_boost_data_indexes:
    pos: 0x98569
    doc: EXCLUSIVE_ITEM_EFFECT_DATA, offset by 1
    size: 0x777
  recycle_shop_item_list:
    pos: 0x98d10
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x360
  type_specific_exclusive_items:
    pos: 0x99070
    doc: |-
      Lists of type-specific exclusive items (silk, dust, gem, globe) for each type.

      type: struct item_id_16[17][4]
    size: 0x88
  recoil_move_list:
    pos: 0x991b8
    doc: |-
      Null-terminated list of all the recoil moves, as 2-byte move IDs.

      type: struct move_id_16[11]
    size: 0x16
  punch_move_list:
    pos: 0x991ce
    doc: |-
      Null-terminated list of all the punch moves, as 2-byte move IDs.

      type: struct move_id_16[16]
    size: 0x20
  move_power_stars_table:
    pos: 0x9a150
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int[6]
    type: s4
    repeat: expr
    repeat-expr: 6
  move_accuracy_stars_table:
    pos: 0x9a168
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int[8]
    type: s4
    repeat: expr
    repeat-expr: 8
  partner_talk_kind_table:
    pos: 0x9d268
    doc: |-
      Table of values for the PARTNER_TALK_KIND script variable.

      type: struct partner_talk_kind_table_entry[11]
    size: 0x58
  script_vars_locals:
    pos: 0x9d450
    doc: |-
      List of special "local" variables available to the script engine. There are 4 16-byte entries.

      Each entry has the same structure as an entry in SCRIPT_VARS.

      type: struct script_local_var_table
    size: 0x40
  script_vars:
    pos: 0x9ddf4
    doc: |-
      List of predefined global variables that track game state, which are available to the script engine. There are 115 16-byte entries.

      These variables underpin the various ExplorerScript global variables you can use in the SkyTemple SSB debugger.

      type: struct script_var_table
    size: 0x730
  portrait_layouts:
    pos: 0x9e598
    doc: |-
      All the possible layouts a portrait can be placed in by default.

      type: struct portrait_layout[32]
    size: 0xc0
  kaomado_filepath:
    pos: 0x9e658
    doc: |-
      "Path of the file where all the portraits are stored. \"FONT/kaomado.kao\", padded with null to a multiple of 4"

      type: char[20]
    type: s1
    repeat: expr
    repeat-expr: 20
  wonder_mail_bits_map:
    pos: 0x9e66c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: uint8_t[32]
    type: u1
    repeat: expr
    repeat-expr: 32
  wonder_mail_bits_swap:
    pos: 0x9e68c
    doc: |-
      Last 2 bytes are unused

      Note: unverified, ported from Irdkwia's notes

      type: uint8_t[36]
    type: u1
    repeat: expr
    repeat-expr: 36
  arm9_unknown_table_na_209e12c:
    pos: 0x9e6b0
    doc: |-
      52*0x2 + 2 bytes unused

      Note: unverified, ported from Irdkwia's notes
    size: 0x38
  arm9_unknown_table_na_209e164:
    pos: 0x9e6e8
    doc: |-
      256*0x1

      Note: unverified, ported from Irdkwia's notes
    size: 0x100
  arm9_unknown_table_na_209e280:
    pos: 0x9e804
    doc: |-
      32*0x1

      Note: unverified, ported from Irdkwia's notes
    size: 0x20
  wonder_mail_encryption_table:
    pos: 0x9e824
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: uint8_t[256]
    type: u1
    repeat: expr
    repeat-expr: 256
  dungeon_data_list:
    pos: 0x9e924
    doc: |-
      Data about every dungeon in the game.

      This is an array of 180 dungeon data list entry structs. Each entry is 4 bytes, and contains floor count information along with an index into the bulk of the dungeon's data in mappa_s.bin.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct dungeon_data_list_entry[180]
    size: 0x2d0
  adventure_log_encounters_monster_ids:
    pos: 0x9ebf4
    doc: |-
      List of monster IDs with a corresponding milestone in the Adventure Log.

      type: struct monster_id_16[38]
    size: 0x4c
  arm9_unknown_data_na_209e6bc:
    pos: 0x9ec40
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  tactic_name_string_ids:
    pos: 0x9ec44
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[12]
    type: s2
    repeat: expr
    repeat-expr: 12
  status_name_string_ids:
    pos: 0x9ec5c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[102]
    type: s2
    repeat: expr
    repeat-expr: 102
  dungeon_return_status_table:
    pos: 0x9ed28
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct dungeon_return_status[91]
    size: 0x16c
  statuses_full_description_string_ids:
    pos: 0x9ee94
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct status_description[103]
    size: 0x19c
  arm9_unknown_data_na_209eaac:
    pos: 0x9f030
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  mission_floor_ranks_and_item_lists_1:
    pos: 0x9f034
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc64
  mission_floors_forbidden:
    pos: 0x9fc98
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct mission_floors_forbidden[100]
    size: 0xc8
  mission_floor_ranks_and_item_lists_2:
    pos: 0x9fd60
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x12f8
  mission_floor_ranks_ptrs:
    pos: 0xa1058
    doc: |-
      Uses MISSION_FLOOR_RANKS_AND_ITEM_LISTS

      Note: unverified, ported from Irdkwia's notes
    type: u4
    repeat: expr
    repeat-expr: 100
  dungeon_restrictions:
    pos: 0xa11e8
    doc: |-
      Data related to dungeon restrictions for every dungeon in the game.

      This is an array of 256 dungeon restriction structs. Each entry is 12 bytes, and contains information about restrictions within the given dungeon.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct dungeon_restriction[256]
    size: 0xc00
  special_band_stat_boost:
    pos: 0xa1df0
    doc: Stat boost value for the Special Band.
    type: s2
  unknown_pp_boost_amount:
    pos: 0xa1df8
    doc: PP boost value for an unknown effect. Corresponds to the flag f_unknown_pp_boost
      in struct move.
    type: s2
  munch_belt_stat_boost:
    pos: 0xa1e00
    doc: Stat boost value for the Munch Belt.
    type: s2
  gummi_stat_boost:
    pos: 0xa1e0c
    doc: Stat boost value if a stat boost occurs when eating normal Gummis.
    type: s2
  min_iq_exclusive_move_user:
    pos: 0xa1e10
    doc: Minimum IQ required for enemies to use Exclusive-Move User
    type: s4
  wonder_gummi_iq_gain:
    pos: 0xa1e14
    doc: IQ gain when ingesting wonder gummis.
    type: s2
  aura_bow_stat_boost:
    pos: 0xa1e1c
    doc: Stat boost value for the aura bows.
    type: s2
  multitalent_pp_boost_amount:
    pos: 0xa1e24
    doc: PP boost value for the Multitalent IQ skill.
    type: s2
  min_iq_item_master:
    pos: 0xa1e28
    doc: Minimum IQ required for enemies to use Item Master
    type: s4
  def_scarf_stat_boost:
    pos: 0xa1e2c
    doc: Stat boost value for the Defense Scarf.
    type: s2
  power_band_stat_boost:
    pos: 0xa1e30
    doc: Stat boost value for the Power Band.
    type: s2
  wonder_gummi_stat_boost:
    pos: 0xa1e34
    doc: Stat boost value if a stat boost occurs when eating Wonder Gummis.
    type: s2
  zinc_band_stat_boost:
    pos: 0xa1e38
    doc: Stat boost value for the Zinc Band.
    type: s2
  egg_hp_bonus:
    pos: 0xa1e3c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: s2
  evolution_hp_bonus:
    pos: 0xa1e48
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: s2
  exclusive_item_pp_boost_amount:
    pos: 0xa1e4c
    doc: PP boost value for exclusive items that boost move PP.
    type: s2
  damage_formula_flv_shift:
    pos: 0xa1e50
    doc: The constant shift added to the "FLV" intermediate quantity in the damage
      formula (see dungeon::last_move_damage_calc_flv), as a binary fixed-point number
      with 8 fraction bits (50).
    type: s4
  evolution_physical_stat_bonuses:
    pos: 0xa1e54
    doc: |-
      0x2: Atk + 0x2: Def

      Note: unverified, ported from Irdkwia's notes
    type: s2
    repeat: expr
    repeat-expr: 2
  damage_formula_constant_shift:
    pos: 0xa1e58
    doc: |-
      The constant shift applied to the overall output of the "unshifted base" damage formula (the sum of the scaled AT, DEF, and ClampedLn terms), as a binary fixed-point number with 8 fraction bits (-311).

      The value of -311 is notably equal to -round[DAMAGE_FORMULA_LN_PREFACTOR * ln(DAMAGE_FORMULA_LN_ARG_PREFACTOR * DAMAGE_FORMULA_FLV_SHIFT)]. This is probably not a coincidence.
    type: s4
  damage_formula_flv_deficit_divisor:
    pos: 0xa1e5c
    doc: The divisor of the (AT - DEF) term within the "FLV" intermediate quantity
      in the damage formula (see dungeon::last_move_damage_calc_flv), as a binary
      fixed-point number with 8 fraction bits (8).
    type: s4
  egg_stat_bonuses:
    pos: 0xa1e60
    doc: |-
      0x2: Atk + 0x2: SpAtk + 0x2: Def + 0x2: SpDef

      Note: unverified, ported from Irdkwia's notes
    type: s2
    repeat: expr
    repeat-expr: 4
  evolution_special_stat_bonuses:
    pos: 0xa1e68
    doc: |-
      0x2: SpAtk + 0x2: SpDef

      Note: unverified, ported from Irdkwia's notes
    type: s2
    repeat: expr
    repeat-expr: 2
  damage_formula_non_team_member_modifier:
    pos: 0xa1e6c
    doc: The divisor applied to the overall output of the "shifted base" damage formula
      (the sum of the scaled AT, Def, ClampedLn, and DAMAGE_FORMULA_CONSTANT_SHIFT
      terms) if the attacker is not a team member (and the current fixed room is not
      the substitute room...for some reason), as a binary fixed-point number with
      8 fraction bits (85/64).
    type: s4
  damage_formula_ln_prefactor:
    pos: 0xa1e70
    doc: The prefactor to the output of the ClampedLn in the damage formula, as a
      binary fixed-point number with 8 fraction bits (50).
    type: s4
  damage_formula_def_prefactor:
    pos: 0xa1e74
    doc: The prefactor to the "DEF" (defense) intermediate quantity in the damage
      formula (see dungeon::last_move_damage_calc_def), as a binary fixed-point number
      with 8 fraction bits (-0.5).
    type: s4
  damage_formula_at_prefactor:
    pos: 0xa1e78
    doc: The prefactor to the "AT" (attack) intermediate quantity in the damage formula
      (see dungeon::last_move_damage_calc_at), as a binary fixed-point number with
      8 fraction bits (153/256, which is close to 0.6).
    type: s4
  damage_formula_ln_arg_prefactor:
    pos: 0xa1e7c
    doc: The prefactor to the argument of ClampedLn in the damage formula (FLV + DAMAGE_FORMULA_FLV_SHIFT),
      as a binary fixed-point number with 8 fraction bits (10).
    type: s4
  forbidden_forgot_move_list:
    pos: 0xa1e9c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct forbidden_forgot_move_entry[3]
    size: 0x12
  tactics_unlock_level_table:
    pos: 0xa1ec4
    doc: 'type: int16_t[12]'
    type: s2
    repeat: expr
    repeat-expr: 12
  client_level_table:
    pos: 0xa1efc
    doc: |-
      Still a guess

      Note: unverified, ported from Irdkwia's notes

      type: int16_t[16]
    type: s2
    repeat: expr
    repeat-expr: 16
  outlaw_level_table:
    pos: 0xa1f1c
    doc: |-
      Table of 2-byte outlaw levels for outlaw missions, indexed by mission rank.

      type: int16_t[16]
    type: s2
    repeat: expr
    repeat-expr: 16
  outlaw_minion_level_table:
    pos: 0xa1f3c
    doc: |-
      Table of 2-byte outlaw minion levels for outlaw hideout missions, indexed by mission rank.

      type: int16_t[16]
    type: s2
    repeat: expr
    repeat-expr: 16
  hidden_power_base_power_table:
    pos: 0xa1f5c
    doc: |-
      Still a guess

      Note: unverified, ported from Irdkwia's notes

      type: int[10]
    type: s4
    repeat: expr
    repeat-expr: 10
  version_exclusive_monsters:
    pos: 0xa1f84
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct version_exclusive_monster[23]
    size: 0x5c
  iq_skill_restrictions:
    pos: 0xa1fe0
    doc: |-
      Table of 2-byte values for each IQ skill that represent a group. IQ skills in the same group can not be enabled at the same time.

      type: int16_t[69]
    type: s2
    repeat: expr
    repeat-expr: 69
  secondary_terrain_types:
    pos: 0xa206c
    doc: |-
      The type of secondary terrain for each dungeon in the game.

      This is an array of 200 bytes. Each byte is an enum corresponding to one dungeon.

      type: struct secondary_terrain_type_8[200]
    size: 0xc8
  sentry_duty_monster_ids:
    pos: 0xa2134
    doc: |-
      Table of monster IDs usable in the sentry duty minigame.

      type: struct monster_id_16[102]
    size: 0xcc
  iq_skills:
    pos: 0xa2200
    doc: |-
      Table of 4-byte values for each IQ skill that represent the required IQ value to unlock a skill.

      type: int[69]
    type: s4
    repeat: expr
    repeat-expr: 69
  iq_group_skills:
    pos: 0xa2314
    doc: "Irdkwia's notes: 25*16*0x1"
    type: u1
    repeat: expr
    repeat-expr: 400
  money_quantity_table:
    pos: 0xa24a4
    doc: |-
      Table that maps money quantity codes (as recorded in, e.g., struct item) to actual amounts.

      type: int[100]
    type: s4
    repeat: expr
    repeat-expr: 100
  arm9_unknown_table_na_20a20b0:
    pos: 0xa2634
    doc: |-
      256*0x2

      Note: unverified, ported from Irdkwia's notes
    size: 0x200
  iq_gummi_gain_table:
    pos: 0xa2834
    doc: 'type: int16_t[18][18]'
    type: s2
    repeat: expr
    repeat-expr: 18
  gummi_belly_restore_table:
    pos: 0xa2abc
    doc: 'type: int16_t[18][18]'
    type: s2
    repeat: expr
    repeat-expr: 18
  bag_capacity_table_special_episodes:
    pos: 0xa2d44
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: uint32_t[5]
    type: u4
    repeat: expr
    repeat-expr: 5
  bag_capacity_table:
    pos: 0xa2d58
    doc: |-
      Array of 4-byte integers containing the bag capacity for each bag level.

      type: uint32_t[8]
    type: u4
    repeat: expr
    repeat-expr: 8
  special_episode_main_characters:
    pos: 0xa2d78
    doc: 'type: struct monster_id_16[100]'
    size: 0xc8
  guest_monster_data:
    pos: 0xa2e40
    doc: |-
      Data for guest monsters that join you during certain story dungeons.

      Array of 18 36-byte entries.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct guest_monster[18]
    size: 0x288
  rank_up_table:
    pos: 0xa30c8
    size: 0xd0
  ds_download_teams:
    pos: 0xa3198
    doc: |-
      Seems like this is just a collection of null-terminated lists concatenated together.

      Note: unverified, ported from Irdkwia's notes

      struct monster_id_16[56]
    size: 0x70
  arm9_unknown_ptr_na_20a2c84:
    pos: 0xa3208
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  unown_species_additional_chars:
    pos: 0xa320c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: enum monster_id[28]
    size: 0x80
  monster_sprite_data:
    pos: 0xa332c
    doc: Contains information about the sprite size and sprite file size of each monster
    size: 0x4b0
  remote_strings:
    pos: 0xa4140
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x2c
  rank_strings_1:
    pos: 0xa416c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x30
  mission_menu_string_ids_1:
    pos: 0xa419c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[8]
    type: s2
    repeat: expr
    repeat-expr: 8
  rank_strings_2:
    pos: 0xa41ac
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x30
  mission_menu_string_ids_2:
    pos: 0xa41dc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[8]
    type: s2
    repeat: expr
    repeat-expr: 8
  rank_strings_3:
    pos: 0xa41ec
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xb4
  mission_dungeon_unlock_table:
    pos: 0xa42ac
    doc: |-
      Irdkwia's notes: SpecialDungeonMissions

      type: struct dungeon_unlock_entry[3]
    size: 0x6
  no_send_item_table:
    pos: 0xa42b2
    doc: |-
      A list of items that are forbidden from being used in a mission sent by Wonder Mail.

      type: struct item_id_16[3]
    size: 0x6
  arm9_unknown_table_na_20a3cc8:
    pos: 0xa42c8
    doc: |-
      14*0x2
      Linked to ARM9_UNKNOWN_TABLE__NA_20A3CE4

      Note: unverified, ported from Irdkwia's notes
    size: 0x1c
  arm9_unknown_table_na_20a3ce4:
    pos: 0xa42e4
    doc: |-
      8*0x2

      Note: unverified, ported from Irdkwia's notes
    size: 0x10
  arm9_unknown_function_table_na_20a3cf4:
    pos: 0xa42f4
    doc: |-
      Could be related to missions

      Note: unverified, ported from Irdkwia's notes
    size: 0x20
  mission_banned_story_monsters:
    pos: 0xa4314
    doc: |-
      Null-terminated list of monster IDs that can't be used (probably as clients or targets) when generating missions before a certain point in the story.

      To be precise, PERFOMANCE_PROGRESS_FLAG[9] must be enabled so these monsters can appear as mission clients.

      type: struct monster_id_16[length / 2]
    size: 0x2a
  item_delivery_table:
    pos: 0xa433e
    doc: |-
      A list of valid items used for delivering an item for a mission client.

      type: struct item_id_16[23]
    size: 0x2e
  mission_rank_points:
    pos: 0xa436c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int[16]
    type: s4
    repeat: expr
    repeat-expr: 16
  mission_banned_monsters:
    pos: 0xa43ac
    doc: |-
      Null-terminated list of monster IDs that can't be used (probably as clients or targets) when generating missions.

      type: struct monster_id_16[124]
    size: 0xf8
  mission_string_ids:
    pos: 0xa44a4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[964]
    type: s2
    repeat: expr
    repeat-expr: 964
  level_list:
    pos: 0xa4cec
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x2470
  events:
    pos: 0xa5bd8
    doc: |-
      Table of levels for the script engine, in which scenes can take place. There are a version-dependent number of 12-byte entries.

      type: struct script_level[length / 12]
    size: 0x1584
  arm9_unknown_table_na_20a68bc:
    pos: 0xa715c
    doc: |-
      6*0x2

      Note: unverified, ported from Irdkwia's notes
    size: 0xc
  demo_teams:
    pos: 0xa7168
    doc: |-
      18*0x4 (Hero ID 0x2, Partner ID 0x2)

      Note: unverified, ported from Irdkwia's notes
    size: 0x48
  actor_list:
    pos: 0xa71b0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x28f8
  entities:
    pos: 0xa8890
    doc: |-
      Table of entities for the script engine, which can move around and do things within a scene. There are 386 12-byte entries.

      type: struct script_entity[386]
    size: 0x1218
  job_window_params_1:
    pos: 0xa9ab8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  job_menu_items_1:
    pos: 0xa9ac8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x20
  job_menu_items_2:
    pos: 0xa9ae8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x20
  job_menu_items_3:
    pos: 0xa9b58
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  job_menu_items_4:
    pos: 0xa9b70
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  job_menu_items_5:
    pos: 0xa9b88
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  job_menu_items_6:
    pos: 0xa9ba0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  job_menu_items_7:
    pos: 0xa9bb8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  job_menu_items_8:
    pos: 0xa9bd0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  job_menu_items_9:
    pos: 0xa9be8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  job_menu_items_10:
    pos: 0xa9c00
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  job_menu_items_11:
    pos: 0xa9c18
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  job_menu_items_12:
    pos: 0xa9c30
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x20
  job_menu_items_13:
    pos: 0xa9c50
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x20
  job_window_params_2:
    pos: 0xa9c70
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  dungeon_swap_id_table:
    pos: 0xa9c80
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct dungeon_id_8[212]
    size: 0xd4
  map_marker_placements:
    pos: 0xa9d70
    doc: |-
      The map marker position of each dungeon on the Wonder Map.

      This is an array of 310 map marker structs. Each entry is 8 bytes, and contains positional information about a dungeon on the map.

      See the struct definitions and Frostbyte's dungeon data document for more info.

      type: struct map_marker[310]
    size: 0x9b0
  lfo_output_voice_update_flags:
    pos: 0xaa840
    size: 0x10
  trig_table:
    pos: 0xaa850
    doc: |-
      Interleaved table of sine and cosine values at 4096 divisions over a full period (2π radians).

      More precisely, the trig_values entry at index i corresponds to {sin(i * 2π/4096), cos(i * 2π/4096)} (each division is ~1/10 of a degree). Values are stored as signed fixed-point numbers with 12 fraction bits.

      type: struct trig_values[4096]
    size: 0x4974
  fx_atan_idx_table:
    pos: 0xae850
    doc: |-
      Table of arctangent values at 129 divisions over the domain [0, 1].

      More precisely, entry at index i corresponds to (atan(i/128) / (π/2)). Values are stored as signed fixed-point numbers with 14 fraction bits.
    type: s2
    repeat: expr
    repeat-expr: 129
  tex_pltt_start_addr_table:
    pos: 0xae954
    type: s2
    repeat: expr
    repeat-expr: 8
  tex_start_addr_table:
    pos: 0xae964
    type: s2
    repeat: expr
    repeat-expr: 48
  arm9_unknown_table_na_20ae924:
    pos: 0xaf1c4
    doc: |-
      724*0x1

      Note: unverified, ported from Irdkwia's notes
    size: 0x2d4
  memory_allocation_arena_getters:
    pos: 0xaf7a0
    doc: |-
      Functions to get the desired memory arena for allocating and freeing heap memory.

      type: struct mem_arena_getters
    size: 0x8
  prng_sequence_num:
    pos: 0xaf7cc
    doc: '[Runtime] The current PRNG sequence number for the general-purpose PRNG.
      See Rand16Bit for more information on how the general-purpose PRNG works.'
    type: u2
  loaded_overlay_group_0:
    pos: 0xafad0
    doc: |-
      [Runtime] The overlay group ID of the overlay currently loaded in slot 0. A group ID of 0 denotes no overlay.

      Overlay group IDs that can be loaded in slot 0:
      - 0x06 (overlay 3)
      - 0x07 (overlay 6)
      - 0x08 (overlay 4)
      - 0x09 (overlay 5)
      - 0x0A (overlay 7)
      - 0x0B (overlay 8)
      - 0x0C (overlay 9)
      - 0x10 (overlay 12)
      - 0x11 (overlay 13)
      - 0x12 (overlay 14)
      - 0x13 (overlay 15)
      - 0x14 (overlay 16)
      - 0x15 (overlay 17)
      - 0x16 (overlay 18)
      - 0x17 (overlay 19)
      - 0x18 (overlay 20)
      - 0x19 (overlay 21)
      - 0x1A (overlay 22)
      - 0x1B (overlay 23)
      - 0x1C (overlay 24)
      - 0x1D (overlay 25)
      - 0x1E (overlay 26)
      - 0x1F (overlay 27)
      - 0x20 (overlay 28)
      - 0x21 (overlay 30)
      - 0x22 (overlay 31)
      - 0x23 (overlay 32)
      - 0x24 (overlay 33)

      type: enum overlay_group_id
    size: 0x4
  loaded_overlay_group_1:
    pos: 0xafad4
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
  loaded_overlay_group_2:
    pos: 0xafad8
    doc: |-
      [Runtime] The overlay group ID of the overlay currently loaded in slot 2. A group ID of 0 denotes no overlay.

      Overlay group IDs that can be loaded in slot 2:
      - 0x1 (overlay 0)
      - 0x2 (overlay 10)
      - 0x3 (overlay 35)

      type: enum overlay_group_id
    size: 0x4
  pack_files_opened:
    pos: 0xaff54
    doc: |-
      [Runtime] A pointer to the 6 opened Pack files (listed at PACK_FILE_PATHS_TABLE)

      type: struct pack_file_opened*
    type: u4
  pack_file_paths_table:
    pos: 0xaff58
    doc: |-
      List of pointers to path strings to all known pack files.
      The game uses this table to load its resources when launching dungeon mode.

      type: char*[6]
    size: 0x18
  bag_items_ptr_mirror:
    pos: 0xaff70
    doc: |-
      [Runtime] Probably a mirror of ram.yml::BAG_ITEMS_PTR?

      Note: unverified, ported from Irdkwia's notes
    type: u4
  item_data_table_ptrs:
    pos: 0xaff78
    doc: |-
      [Runtime] List of pointers to various item data tables.

      The first two pointers are definitely item-related (although the order appears to be flipped between EU/NA?). Not sure about the third pointer.
    type: u4
    repeat: expr
    repeat-expr: 3
  move_data_table_ptr:
    pos: 0xaffb0
    doc: |-
      [Runtime] Points to the contents of the move data table loaded from waza_p.bin

      type: struct move_data_table*
    type: u4
  wan_table:
    pos: 0xb0524
    doc: |-
      pointer to the list of wan sprite loaded in RAM

      struct wan_table*
    type: u4
  render_3d:
    pos: 0xb0540
    doc: |-
      The (seemingly) unique instance render_3d_global in the game

      type: struct render_3d_global
    size: 0x44
  render_3d_functions_64:
    pos: 0xb0584
    doc: |-
      Pointers to the 8 functions available for rendering a render_3d_element_64

      type: render_3d_element_64_fn_t[8]
    size: 0x20
  tbl_talk_group_string_id_start:
    pos: 0xb0614
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[6]
    type: s2
    repeat: expr
    repeat-expr: 6
  keyboard_string_ids:
    pos: 0xb0718
    doc: |-
      30*0x2

      Note: unverified, ported from Irdkwia's notes

      type: int16_t[30]
    type: s2
    repeat: expr
    repeat-expr: 30
  notify_note:
    pos: 0xb0814
    doc: |-
      [Runtime] Flag related to saving and loading state?

      type: bool
    size: 0x1
  default_hero_id:
    pos: 0xb0818
    doc: |-
      The default monster ID for the hero (0x4: Charmander)

      type: struct monster_id_16
    size: 0x2
  default_partner_id:
    pos: 0xb081a
    doc: |-
      The default monster ID for the partner (0x1: Bulbasaur)

      type: struct monster_id_16
    size: 0x2
  game_mode:
    pos: 0xb088c
    doc: |-
      [Runtime] Game mode, see enum game_mode for possible values.

      type: uint8_t
    type: u1
  global_progress_ptr:
    pos: 0xb0890
    doc: |-
      [Runtime]

      type: struct global_progress*
    type: u4
  adventure_log_ptr:
    pos: 0xb0894
    doc: |-
      [Runtime]

      type: struct adventure_log*
    type: u4
  item_tables_ptrs_1:
    pos: 0xb1264
    doc: "Irdkwia's notes: 26*0x4, uses MISSION_FLOOR_RANKS_AND_ITEM_LISTS"
    type: u4
    repeat: expr
    repeat-expr: 26
  unown_species_additional_char_ptr_table:
    pos: 0xb131c
    doc: |-
      Uses UNOWN_SPECIES_ADDITIONAL_CHARS

      Note: unverified, ported from Irdkwia's notes

      type: enum monster_id*[28]
    size: 0x70
  team_member_table_ptr:
    pos: 0xb138c
    doc: Pointer to TEAM_MEMBER_TABLE
    type: u4
  mission_deliver_list_ptr:
    pos: 0xb13a4
    doc: A pointer to a heap-allocated list of items usable for delivery missions
    type: u4
  mission_deliver_count:
    pos: 0xb13a8
    doc: The total number of items usable for delivery missions
    type: s4
  mission_dungeon_list_ptr:
    pos: 0xb13ac
    doc: A pointer to a heap-allocated list of dungeons usable for missions
    type: u4
  mission_dungeon_count:
    pos: 0xb13b0
    doc: The total number of dungeons usable for missions
    type: s4
  mission_monster_list_ptr:
    pos: 0xb13b4
    doc: A pointer to a heap-allocated list of monsters usable for missions
    type: u4
  mission_monster_count:
    pos: 0xb13b8
    doc: The total number of monsters usable for missions
    type: s4
  mission_list_ptr:
    pos: 0xb13bc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: u4
  remote_string_ptr_table:
    pos: 0xb13c0
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: const char*[7]
    size: 0x1c
  rank_string_ptr_table:
    pos: 0xb13dc
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: const char*[16]
    size: 0x40
  smd_events_fun_table:
    pos: 0xb14d4
    doc: |-
      Table of all DSE events, see https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/

      Irdkwia's notes: named DSEEventFunctionPtrTable with length 0x3C0 (note the disagreement), 240*0x4.
    type: u4
    repeat: expr
    repeat-expr: 127
  music_duration_lookup_table_1:
    pos: 0xb1894
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int16_t[128]
    type: s2
    repeat: expr
    repeat-expr: 128
  music_duration_lookup_table_2:
    pos: 0xb1994
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: int32_t[128]
    type: s4
    repeat: expr
    repeat-expr: 128
  lfo_waveform_callbacks:
    pos: 0xb1b94
    size: 0x40
  is_disp_on:
    pos: 0xb34d8
    size: 0x1
  gxi_dma_id:
    pos: 0xb34dc
    type: u4
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
enums: {}
