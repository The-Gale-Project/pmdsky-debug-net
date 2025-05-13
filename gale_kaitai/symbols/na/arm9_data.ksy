doc: |-
  Mappings of data structures within ARM9
meta:
  id: arm9_data
  endian: le
instances:
  secure:
    pos: 0x2000000
    size: 0x800
    doc: "The header of the DS cartridge secure area. See https://problemkaputt.de/gbatek.htm#dscartridgesecurearea"
  start_module_params:
    pos: 0x2000BA0
    size: 0xCC
    doc: Parameters used by the NitroSDK to read the ROM.
  default_memory_arena_size:
    pos: 0x2000E58
    type: u4
    doc: "Length in bytes of the default memory allocation arena, 1991680."
  log_max_arg:
    pos: 0x2002220
    type: u4
    doc: "The maximum argument value for the Log function, 2047."
  damage_source_code_orb_item:
    pos: 0x200CA84
    type: u4
    doc: "The damage source value for any item in CATEGORY_ORBS, 0x262."
  damage_source_code_non_orb_item:
    pos: 0x200CA88
    type: u4
    doc: "The damage source value for any item not in CATEGORY_ORBS, 0x263."
  AURA_BOW_ID_LAST:
    pos:
      EU: 0x200CCBC
      NA: 0x200CC34
      JP: 0x200CC34
    size:
      EU: 0x4
      NA: 0x4
    doc: Highest item ID of the aura bows.
  NUMBER_OF_ITEMS:
    pos:
      EU:
        - 0x200E88C
        - 0x200E930
      NA:
        - 0x200E7BC
        - 0x200E860
    size:
      EU: 0x4
      NA: 0x4
    doc: Number of items in the game.
  MAX_MONEY_CARRIED:
    pos:
      EU: 0x200EDF8
      NA: 0x200ED50
      JP: 0x200ED80
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: "Maximum amount of money the player can carry, 99999."
  MAX_MONEY_STORED:
    pos:
      EU: 0x20107F8
      NA: 0x2010750
      JP: 0x2010720
    size:
      EU: 0x4
      NA: 0x4
    doc: "Maximum amount of money the player can store in the Duskull Bank, 9999999."
  WINDOW_LIST_PTR:
    pos:
      NA: 0x2028350
    size:
      NA: 0x4
    doc: Hard-coded pointer to WINDOW_LIST.
  SCRIPT_VARS_VALUES_PTR:
    pos:
      EU:
        - 0x204B630
        - 0x204B81C
        - 0x204C764
        - 0x204C7BC
      NA:
        - 0x204B2F8
        - 0x204B4E4
        - 0x204C42C
        - 0x204C484
    size:
      EU: 0x4
      NA: 0x4
    doc: Hard-coded pointer to SCRIPT_VARS_VALUES.
  MAX_PLAY_TIME:
    pos:
      EU: 0x2051188
    size:
      EU: 0x4
    doc: |-
      Maximum number of seconds that the file timer counts up to.
      
      35999999 seconds (one second under 10000 hours).
  MONSTER_ID_LIMIT:
    pos:
      EU: 0x2054818
      NA: 0x205449C
    size:
      EU: 0x4
      NA: 0x4
    doc: One more than the maximum valid monster ID (0x483).
  MAX_RECRUITABLE_TEAM_MEMBERS:
    pos:
      EU:
        - 0x20555B4
        - 0x20559C8
      NA:
        - 0x2055238
        - 0x205564C
    size:
      EU: 0x4
      NA: 0x4
    doc: "555, appears to be the maximum number of members recruited to an exploration team, at least for the purposes of some checks that need to iterate over all team members."
  NATURAL_LOG_VALUE_TABLE:
    pos:
      EU: 0x20917E0
      NA: 0x2091448
      JP: 0x2091730
    size:
      NA: 0x1000
    doc: |-
      A table of values for the natural log function corresponding to integer arguments in the range [0, 2047].
      
      Each value is stored as a 16-bit fixed-point number with 12 fractional bits. I.e., to get the actual natural log value, take the table entry and divide it by 2^12.
      
      The value at an input of 0 is just listed as 0; the Log function makes sure the input is always at least 1 before reading the table.
      
      type: fx16_12[2048]
  CART_REMOVED_IMG_DATA:
    pos:
      EU: 0x2092EE4
      NA: 0x2092AE8
      JP: 0x2092DD0
    size:
      EU: 0x2000
      NA: 0x2000
      JP: 0x2000
  STRING_DEBUG_EMPTY:
    pos:
      EU: 0x2094EF8
      NA: 0x2094AFC
      JP: 0x2094DE4
    size:
      NA: 0x4
  STRING_DEBUG_FORMAT_LINE_FILE:
    pos:
      EU: 0x2094EFC
      NA: 0x2094B00
      JP: 0x2094DE8
    size:
      NA: 0x1C
  STRING_DEBUG_NO_PROG_POS:
    pos:
      EU: 0x2094F18
      NA: 0x2094B1C
      JP: 0x2094E04
    size:
      NA: 0x18
  STRING_DEBUG_SPACED_PRINT:
    pos:
      EU: 0x2094F30
      NA: 0x2094B34
      JP: 0x2094E1C
    size:
      NA: 0xC
  STRING_DEBUG_FATAL:
    pos:
      EU: 0x2094F3C
      NA: 0x2094B40
      JP: 0x2094E28
    size:
      NA: 0x14
  STRING_DEBUG_NEWLINE:
    pos:
      EU: 0x2094F50
      NA: 0x2094B54
      JP: 0x2094E3C
    size:
      NA: 0x4
  STRING_DEBUG_LOG_NULL:
    pos:
      EU: 0x2094F54
      NA: 0x2094B58
      JP: 0x2094E40
    size:
      NA: 0x8
  STRING_DEBUG_STRING_NEWLINE:
    pos:
      EU: 0x2094F5C
      NA: 0x2094B60
      JP: 0x2094E48
    size:
      NA: 0x4
  STRING_EFFECT_EFFECT_BIN:
    pos:
      EU: 0x2094F60
      NA: 0x2094B64
      JP: 0x2094E4C
    size:
      NA: 0x14
  STRING_MONSTER_MONSTER_BIN:
    pos:
      EU: 0x2094F74
      NA: 0x2094B78
      JP: 0x2094E60
    size:
      NA: 0x14
  STRING_BALANCE_M_LEVEL_BIN:
    pos:
      EU: 0x2094F88
      NA: 0x2094B8C
      JP: 0x2094E74
    size:
      NA: 0x14
  STRING_DUNGEON_DUNGEON_BIN:
    pos:
      EU: 0x2094F9C
      NA: 0x2094BA0
      JP: 0x2094E88
    size:
      NA: 0x14
  STRING_MONSTER_M_ATTACK_BIN:
    pos:
      EU: 0x2094FB0
      NA: 0x2094BB4
      JP: 0x2094E9C
    size:
      NA: 0x18
  STRING_MONSTER_M_GROUND_BIN:
    pos:
      EU: 0x2094FC8
      NA: 0x2094BCC
      JP: 0x2094EB4
    size:
      NA: 0x18
  STRING_FILE_DIRECTORY_INIT:
    pos:
      EU: 0x2094FE0
      NA: 0x2094BE4
      JP: 0x2094ECC
    size:
      NA: 0x28
  AVAILABLE_ITEMS_IN_GROUP_TABLE:
    pos:
      EU: 0x2095130
      NA: 0x2094D34
      JP: 0x2095028
    size:
      EU: 0x3200
      NA: 0x3200
      JP: 0x3200
    doc: |-
      100*0x80
      Linked to the dungeon group id
      
      Note: unverified, ported from Irdkwia's notes
  ARM9_UNKNOWN_TABLE__NA_2097FF8:
    pos:
      EU: 0x2098444
      NA: 0x2097FF8
      JP: 0x20982EC
    size:
      EU: 0x40
      NA: 0x40
      JP: 0x40
    doc: |-
      16*0x4 (0x2+0x2)
      
      Note: unverified, ported from Irdkwia's notes
  KECLEON_SHOP_ITEM_TABLE_LISTS_1:
    pos:
      EU: 0x2098504
      NA: 0x20980C0
      JP: 0x20983B4
    size:
      EU: 0x10
      NA: 0x10
      JP: 0x10
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: enum item_id[4]
  KECLEON_SHOP_ITEM_TABLE_LISTS_2:
    pos:
      EU: 0x2098514
      NA: 0x20980D0
      JP: 0x20983C4
    size:
      EU: 0x10
      NA: 0x10
      JP: 0x10
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: enum item_id[4]
  EXCLUSIVE_ITEM_STAT_BOOST_DATA:
    aliases:
      - EXCLUSIVE_ITEM_ATTACK_BOOSTS
    pos:
      EU: 0x209852C
      NA: 0x20980E8
      JP: 0x20983DC
    size:
      EU: 0x3C
      NA: 0x3C
      JP: 0x3C
    doc: |-
      Contains stat boost effects for different exclusive item classes.
      
      Each 4-byte entry contains the boost data for (attack, defense, special attack, special defense), 1 byte each, for a specific exclusive item class, indexed according to the stat boost data index list.
      
      type: struct exclusive_item_stat_boost_entry[15]
  EXCLUSIVE_ITEM_DEFENSE_BOOSTS:
    pos:
      EU: 0x209852D
      NA: 0x20980E9
      JP: 0x20983DD
    size:
      EU: 0x39
      NA: 0x39
      JP: 0x39
    doc: "EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 1"
  EXCLUSIVE_ITEM_SPECIAL_ATTACK_BOOSTS:
    pos:
      EU: 0x209852E
      NA: 0x20980EA
      JP: 0x20983DE
    size:
      EU: 0x39
      NA: 0x39
      JP: 0x39
    doc: "EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 2"
  EXCLUSIVE_ITEM_SPECIAL_DEFENSE_BOOSTS:
    pos:
      EU: 0x209852F
      NA: 0x20980EB
      JP: 0x20983DF
    size:
      EU: 0x39
      NA: 0x39
      JP: 0x39
    doc: "EXCLUSIVE_ITEM_STAT_BOOST_DATA, offset by 3"
  EXCLUSIVE_ITEM_EFFECT_DATA:
    pos:
      EU: 0x2098568
      NA: 0x2098124
      JP: 0x2098418
    size:
      EU: 0x778
      NA: 0x778
      JP: 0x778
    doc: |-
      Contains special effects for each exclusive item.
      
      Each entry is 2 bytes, with the first entry corresponding to the first exclusive item (Prism Ruff). The first byte is the exclusive item effect ID, and the second byte is an index into other data tables (related to the more generic stat boosting effects for specific monsters).
      
      type: struct exclusive_item_effect_entry[956]
  EXCLUSIVE_ITEM_STAT_BOOST_DATA_INDEXES:
    pos:
      EU: 0x2098569
      NA: 0x2098125
      JP: 0x2098419
    size:
      EU: 0x777
      NA: 0x777
    doc: "EXCLUSIVE_ITEM_EFFECT_DATA, offset by 1"
  RECYCLE_SHOP_ITEM_LIST:
    pos:
      EU: 0x2098D10
      NA: 0x20988CC
      JP: 0x2098BC0
    size:
      EU: 0x360
      NA: 0x360
      JP: 0x360
    doc: "Note: unverified, ported from Irdkwia's notes"
  TYPE_SPECIFIC_EXCLUSIVE_ITEMS:
    pos:
      EU: 0x2099070
      NA: 0x2098C2C
      JP: 0x2098F20
    size:
      EU: 0x88
      NA: 0x88
      JP: 0x88
    doc: |-
      Lists of type-specific exclusive items (silk, dust, gem, globe) for each type.
      
      type: struct item_id_16[17][4]
  RECOIL_MOVE_LIST:
    pos:
      EU: 0x20991B8
      NA: 0x2098D74
      JP: 0x2099068
    size:
      EU: 0x16
      NA: 0x16
      JP: 0x16
    doc: |-
      Null-terminated list of all the recoil moves, as 2-byte move IDs.
      
      type: struct move_id_16[11]
  PUNCH_MOVE_LIST:
    pos:
      EU: 0x20991CE
      NA: 0x2098D8A
      JP: 0x209907E
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: |-
      Null-terminated list of all the punch moves, as 2-byte move IDs.
      
      type: struct move_id_16[16]
  MOVE_POWER_STARS_TABLE:
    pos:
      EU: 0x209A150
      NA: 0x2099CD4
      JP: 0x2099FC8
    size:
      NA: 0x18
      JP: 0x18
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int[6]
  MOVE_ACCURACY_STARS_TABLE:
    pos:
      EU: 0x209A168
      NA: 0x2099CEC
      JP: 0x2099FE0
    size:
      NA: 0x20
      JP: 0x20
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int[8]
  PARENT_MENU_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B3CC
      NA: 0x209AE90
      JP: 0x209B7E4
    size:
      NA: 0x10
    doc: |-
      Default window_params for a simple_menu created with CreateParentMenuInternal.
      
      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateParentMenuInternal.
      
      Additionally, width and height are 0, and will be computed in CreateParentMenuInternal.
  SIMPLE_MENU_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B3DC
      NA: 0x209AEA0
      JP: 0x209B7F4
    size:
      NA: 0x10
    doc: |-
      Default window_params for a simple_menu.
      
      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateSimpleMenuInternal.
      
      Additionally, width and height are 0, and will be computed in CreateSimpleMenuInternal.
  ADVANCED_MENU_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B3EC
      NA: 0x209AEB0
      JP: 0x209B804
    size:
      NA: 0x10
    doc: |-
      Default window_params for an advanced_menu.
      
      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateAdvancedMenu.
      
      Additionally, width and height are 0, and will be computed in CreateAdvancedMenu.
  COLLECTION_MENU_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B3FC
      NA: 0x209AEC0
      JP: 0x209B814
    size:
      NA: 0x10
    doc: |-
      Default window_params for a collection_menu.
      
      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateCollectionMenu.
      
      Additionally, width and height are 0, and will be computed in CreateCollectionMenu.
  OPTIONS_MENU_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B40C
      NA: 0x209AED0
      JP: 0x209B824
    size:
      NA: 0x10
    doc: |-
      Default window_params for an options_menu.
      
      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateOptionsMenu.
      
      Additionally, width and height are 0, and will be computed in CreateOptionsMenu.
  DEBUG_MENU_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B448
      NA: 0x209AF0C
      JP: 0x209B860
    size:
      NA: 0x10
    doc: |-
      Default window_params for a debug_menu.
      
      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateDebugMenu.
      
      Additionally, width and height are 0, and will be computed in CreateDebugMenu.
  SCROLL_BOX_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B458
      NA: 0x209AF1C
      JP: 0x209B870
    size:
      NA: 0x10
    doc: Default window_params for a scroll_box.
  DIALOGUE_BOX_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B468
      NA: 0x209AF2C
      JP: 0x209B880
    size:
      NA: 0x10
    doc: Default window_params for a dialogue_box.
  PORTRAIT_BOX_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B478
      NA: 0x209AF3C
      JP: 0x209B890
    size:
      NA: 0x10
    doc: |-
      Default window_params for a portrait_box.
      
      Note that the screen and box type are unset, and are determined in CreatePortraitBox.
  TEXT_BOX_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B488
      NA: 0x209AF4C
      JP: 0x209B8A0
    size:
      NA: 0x10
    doc: Default window_params for a text_box.
  AREA_NAME_BOX_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B498
      NA: 0x209AF5C
      JP: 0x209B8B0
    size:
      NA: 0x10
    doc: |-
      Default window_params for an area_name_box.
      
      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateAreaNameBox.
      
      Additionally, width and height are 0, and will be computed in CreateAreaNameBox.
  CONTROLS_CHART_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B4B4
      NA: 0x209AF78
      JP: 0x209B8CC
    size:
      NA: 0x10
    doc: Default window_params for a controls_chart.
  ALERT_BOX_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B4D0
      NA: 0x209AF94
      JP: 0x209B8E8
    size:
      NA: 0x10
    doc: Default window_params for an alert_box.
  ADVANCED_TEXT_BOX_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B4E0
      NA: 0x209AFA4
      JP: 0x209B8F8
    size:
      NA: 0x10
    doc: |-
      Default window_params for an advanced_text_box.
      
      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateAdvancedTextBoxInternal.
  TEAM_SELECTION_MENU_DEFAULT_WINDOW_PARAMS:
    pos:
      EU: 0x209B4F0
      NA: 0x209AFB4
      JP: 0x209B908
    size:
      NA: 0x10
    doc: |-
      Default window_params for a team_selection_menu.
      
      Note that x_offset and y_offset refer to the right and bottom edges, since they will be paired with the x_offset_end and y_offset_end window flags in CreateTeamSelectionMenu.
      
      Additionally, width and height are 0, and will be computed in CreateTeamSelectionMenu.
  PARTNER_TALK_KIND_TABLE:
    pos:
      EU: 0x209D268
      NA: 0x209CCE4
      JP: 0x209E0B8
    size:
      EU: 0x58
      NA: 0x58
      JP: 0x58
    doc: |-
      Table of values for the PARTNER_TALK_KIND script variable.
      
      type: struct partner_talk_kind_table_entry[11]
  SCRIPT_VARS_LOCALS:
    pos:
      EU: 0x209D450
      NA: 0x209CECC
      JP: 0x209E2A0
    size:
      EU: 0x40
      NA: 0x40
      JP: 0x40
    doc: |-
      List of special "local" variables available to the script engine. There are 4 16-byte entries.
      
      Each entry has the same structure as an entry in SCRIPT_VARS.
      
      type: struct script_local_var_table
  SCRIPT_VARS:
    pos:
      EU: 0x209DDF4
      NA: 0x209D870
      JP: 0x209EC44
    size:
      EU: 0x730
      NA: 0x730
      JP: 0x730
    doc: |-
      List of predefined global variables that track game state, which are available to the script engine. There are 115 16-byte entries.
      
      These variables underpin the various ExplorerScript global variables you can use in the SkyTemple SSB debugger.
      
      type: struct script_var_table
  PORTRAIT_LAYOUTS:
    pos:
      EU: 0x209E598
      NA: 0x209E014
      JP: 0x209F3E8
    size:
      EU: 0xC0
      NA: 0xC0
      JP: 0xC0
    doc: |-
      All the possible layouts a portrait can be placed in by default.
      
      type: struct portrait_layout[32]
  KAOMADO_FILEPATH:
    pos:
      EU: 0x209E658
      NA: 0x209E0D4
      JP: 0x209F4A8
    size:
      NA: 0x14
    doc: |-
      "Path of the file where all the portraits are stored. \"FONT/kaomado.kao\", padded with null to a multiple of 4"
      
      type: char[20]
  WONDER_MAIL_BITS_MAP:
    pos:
      EU: 0x209E66C
      NA: 0x209E0E8
      JP: 0x209F4BC
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: uint8_t[32]
  WONDER_MAIL_BITS_SWAP:
    pos:
      EU: 0x209E68C
      NA: 0x209E108
      JP: 0x209F4DC
    size:
      EU: 0x24
      NA: 0x24
      JP: 0x24
    doc: |-
      Last 2 bytes are unused
      
      Note: unverified, ported from Irdkwia's notes
      
      type: uint8_t[36]
  ARM9_UNKNOWN_TABLE__NA_209E12C:
    pos:
      EU: 0x209E6B0
      NA: 0x209E12C
      JP: 0x209F500
    size:
      EU: 0x38
      NA: 0x38
      JP: 0x38
    doc: |-
      52*0x2 + 2 bytes unused
      
      Note: unverified, ported from Irdkwia's notes
  ARM9_UNKNOWN_TABLE__NA_209E164:
    pos:
      EU: 0x209E6E8
      NA: 0x209E164
      JP: 0x209F538
    size:
      EU: 0x100
      NA: 0x100
      JP: 0x100
    doc: |-
      256*0x1
      
      Note: unverified, ported from Irdkwia's notes
  ARM9_UNKNOWN_TABLE__NA_209E280:
    pos:
      EU: 0x209E804
      NA: 0x209E280
      JP: 0x209F654
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: |-
      32*0x1
      
      Note: unverified, ported from Irdkwia's notes
  WONDER_MAIL_ENCRYPTION_TABLE:
    pos:
      EU: 0x209E824
      NA: 0x209E2A0
      JP: 0x209F674
    size:
      EU: 0x100
      NA: 0x100
      JP: 0x100
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: uint8_t[256]
  DUNGEON_DATA_LIST:
    pos:
      EU: 0x209E924
      NA: 0x209E3A0
      JP: 0x209F774
    size:
      EU: 0x2D0
      NA: 0x2D0
      JP: 0x2D0
    doc: |-
      Data about every dungeon in the game.
      
      This is an array of 180 dungeon data list entry structs. Each entry is 4 bytes, and contains floor count information along with an index into the bulk of the dungeon's data in mappa_s.bin.
      
      See the struct definitions and Frostbyte's dungeon data document for more info.
      
      type: struct dungeon_data_list_entry[180]
  ADVENTURE_LOG_ENCOUNTERS_MONSTER_IDS:
    pos:
      EU: 0x209EBF4
      NA: 0x209E670
      JP: 0x209FA44
    size:
      EU: 0x4C
      NA: 0x4C
      JP: 0x4C
    doc: |-
      List of monster IDs with a corresponding milestone in the Adventure Log.
      
      type: struct monster_id_16[38]
  ARM9_UNKNOWN_DATA__NA_209E6BC:
    pos:
      EU: 0x209EC40
      NA: 0x209E6BC
      JP: 0x209FA90
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  TACTIC_NAME_STRING_IDS:
    pos:
      EU: 0x209EC44
      NA: 0x209E6C0
      JP: 0x209FA94
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int16_t[12]
  STATUS_NAME_STRING_IDS:
    pos:
      EU: 0x209EC5C
      NA: 0x209E6D8
      JP: 0x209FAAC
    size:
      EU: 0xCC
      NA: 0xCC
      JP: 0xCC
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int16_t[102]
  DUNGEON_RETURN_STATUS_TABLE:
    pos:
      EU: 0x209ED28
      NA: 0x209E7A4
      JP: 0x209FB78
    size:
      EU: 0x16C
      NA: 0x16C
      JP: 0x16C
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: struct dungeon_return_status[91]
  STATUSES_FULL_DESCRIPTION_STRING_IDS:
    pos:
      EU: 0x209EE94
      NA: 0x209E910
      JP: 0x209FCE4
    size:
      EU: 0x19C
      NA: 0x19C
      JP: 0x19C
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: struct status_description[103]
  ARM9_UNKNOWN_DATA__NA_209EAAC:
    pos:
      EU: 0x209F030
      NA: 0x209EAAC
      JP: 0x209FE80
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  MISSION_FLOOR_RANKS_AND_ITEM_LISTS_1:
    pos:
      EU: 0x209F034
      NA: 0x209EAB0
      JP: 0x209FE84
    size:
      EU: 0xC64
      NA: 0xC64
      JP: 0xC64
    doc: "Note: unverified, ported from Irdkwia's notes"
  MISSION_FLOORS_FORBIDDEN:
    pos:
      EU: 0x209FC98
      NA: 0x209F714
      JP: 0x20A0AE8
    size:
      EU: 0xC8
      NA: 0xC8
      JP: 0xC8
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: struct mission_floors_forbidden[100]
  MISSION_FLOOR_RANKS_AND_ITEM_LISTS_2:
    pos:
      EU: 0x209FD60
      NA: 0x209F7DC
      JP: 0x20A0BB0
    size:
      EU: 0x12F8
      NA: 0x12F8
      JP: 0x12F8
    doc: "Note: unverified, ported from Irdkwia's notes"
  MISSION_FLOOR_RANKS_PTRS:
    pos:
      EU: 0x20A1058
      NA: 0x20A0AD4
      JP: 0x20A1EA8
    size:
      EU: 0x190
      NA: 0x190
      JP: 0x190
    doc: |-
      Uses MISSION_FLOOR_RANKS_AND_ITEM_LISTS
      
      Note: unverified, ported from Irdkwia's notes
  DUNGEON_RESTRICTIONS:
    pos:
      EU: 0x20A11E8
      NA: 0x20A0C64
      JP: 0x20A2038
    size:
      EU: 0xC00
      NA: 0xC00
      JP: 0xC00
    doc: |-
      Data related to dungeon restrictions for every dungeon in the game.
      
      This is an array of 256 dungeon restriction structs. Each entry is 12 bytes, and contains information about restrictions within the given dungeon.
      
      See the struct definitions and Frostbyte's dungeon data document for more info.
      
      type: struct dungeon_restriction[256]
  SPECIAL_BAND_STAT_BOOST:
    pos:
      EU: 0x20A1DF0
      NA: 0x20A186C
      JP: 0x20A2C40
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: Stat boost value for the Special Band.
  UNKNOWN_PP_BOOST_AMOUNT:
    pos:
      EU: 0x20A1DF8
      NA: 0x20A1874
      JP: 0x20A2C48
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: PP boost value for an unknown effect. Corresponds to the flag f_unknown_pp_boost in struct move.
  MUNCH_BELT_STAT_BOOST:
    pos:
      EU: 0x20A1E00
      NA: 0x20A187C
      JP: 0x20A2C50
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: Stat boost value for the Munch Belt.
  GUMMI_STAT_BOOST:
    pos:
      EU: 0x20A1E0C
      NA: 0x20A1888
      JP: 0x20A2C5C
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: Stat boost value if a stat boost occurs when eating normal Gummis.
  MIN_IQ_EXCLUSIVE_MOVE_USER:
    pos:
      EU: 0x20A1E10
      NA: 0x20A188C
      JP: 0x20A2C60
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: Minimum IQ required for enemies to use Exclusive-Move User
  WONDER_GUMMI_IQ_GAIN:
    pos:
      EU: 0x20A1E14
      NA: 0x20A1890
      JP: 0x20A2C64
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: IQ gain when ingesting wonder gummis.
  AURA_BOW_STAT_BOOST:
    pos:
      EU: 0x20A1E1C
      NA: 0x20A1898
      JP: 0x20A2C6C
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: Stat boost value for the aura bows.
  MULTITALENT_PP_BOOST_AMOUNT:
    pos:
      EU: 0x20A1E24
      NA: 0x20A18A0
      JP: 0x20A2C74
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: PP boost value for the Multitalent IQ skill.
  MIN_IQ_ITEM_MASTER:
    pos:
      EU: 0x20A1E28
      NA: 0x20A18A4
      JP: 0x20A2C78
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: Minimum IQ required for enemies to use Item Master
  DEF_SCARF_STAT_BOOST:
    pos:
      EU: 0x20A1E2C
      NA: 0x20A18A8
      JP: 0x20A2C7C
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: Stat boost value for the Defense Scarf.
  POWER_BAND_STAT_BOOST:
    pos:
      EU: 0x20A1E30
      NA: 0x20A18AC
      JP: 0x20A2C80
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: Stat boost value for the Power Band.
  WONDER_GUMMI_STAT_BOOST:
    pos:
      EU: 0x20A1E34
      NA: 0x20A18B0
      JP: 0x20A2C84
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: Stat boost value if a stat boost occurs when eating Wonder Gummis.
  ZINC_BAND_STAT_BOOST:
    pos:
      EU: 0x20A1E38
      NA: 0x20A18B4
      JP: 0x20A2C88
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: Stat boost value for the Zinc Band.
  EGG_HP_BONUS:
    pos:
      EU: 0x20A1E3C
      NA: 0x20A18B8
      JP: 0x20A2C8C
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: "Note: unverified, ported from Irdkwia's notes"
  EVOLUTION_HP_BONUS:
    pos:
      EU: 0x20A1E48
      NA: 0x20A18C4
      JP: 0x20A2C98
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: "Note: unverified, ported from Irdkwia's notes"
  EXCLUSIVE_ITEM_PP_BOOST_AMOUNT:
    pos:
      EU: 0x20A1E4C
      NA: 0x20A18C8
      JP: 0x20A2C9C
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: PP boost value for exclusive items that boost move PP.
  DAMAGE_FORMULA_FLV_SHIFT:
    pos:
      EU: 0x20A1E50
      NA: 0x20A18CC
      JP: 0x20A2CA0
    size:
      NA: 0x4
      JP: 0x4
    doc: "The constant shift added to the \"FLV\" intermediate quantity in the damage formula (see dungeon::last_move_damage_calc_flv), as a binary fixed-point number with 8 fraction bits (50)."
  EVOLUTION_PHYSICAL_STAT_BONUSES:
    pos:
      EU: 0x20A1E54
      NA: 0x20A18D0
      JP: 0x20A2CA4
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: |-
      0x2: Atk + 0x2: Def
      
      Note: unverified, ported from Irdkwia's notes
  DAMAGE_FORMULA_CONSTANT_SHIFT:
    pos:
      EU: 0x20A1E58
      NA: 0x20A18D4
      JP: 0x20A2CA8
    size:
      NA: 0x4
      JP: 0x4
    doc: |-
      The constant shift applied to the overall output of the "unshifted base" damage formula (the sum of the scaled AT, DEF, and ClampedLn terms), as a binary fixed-point number with 8 fraction bits (-311).
      
      The value of -311 is notably equal to -round[DAMAGE_FORMULA_LN_PREFACTOR * ln(DAMAGE_FORMULA_LN_ARG_PREFACTOR * DAMAGE_FORMULA_FLV_SHIFT)]. This is probably not a coincidence.
  DAMAGE_FORMULA_FLV_DEFICIT_DIVISOR:
    pos:
      EU: 0x20A1E5C
      NA: 0x20A18D8
      JP: 0x20A2CAC
    size:
      NA: 0x4
      JP: 0x4
    doc: "The divisor of the (AT - DEF) term within the \"FLV\" intermediate quantity in the damage formula (see dungeon::last_move_damage_calc_flv), as a binary fixed-point number with 8 fraction bits (8)."
  EGG_STAT_BONUSES:
    pos:
      EU: 0x20A1E60
      NA: 0x20A18DC
      JP: 0x20A2CB0
    size:
      EU: 0x8
      NA: 0x8
      JP: 0x8
    doc: |-
      0x2: Atk + 0x2: SpAtk + 0x2: Def + 0x2: SpDef
      
      Note: unverified, ported from Irdkwia's notes
  EVOLUTION_SPECIAL_STAT_BONUSES:
    pos:
      EU: 0x20A1E68
      NA: 0x20A18E4
      JP: 0x20A2CB8
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: |-
      0x2: SpAtk + 0x2: SpDef
      
      Note: unverified, ported from Irdkwia's notes
  DAMAGE_FORMULA_NON_TEAM_MEMBER_MODIFIER:
    pos:
      EU: 0x20A1E6C
      NA: 0x20A18E8
      JP: 0x20A2CBC
    size:
      NA: 0x4
      JP: 0x4
    doc: "The divisor applied to the overall output of the \"shifted base\" damage formula (the sum of the scaled AT, Def, ClampedLn, and DAMAGE_FORMULA_CONSTANT_SHIFT terms) if the attacker is not a team member (and the current fixed room is not the substitute room...for some reason), as a binary fixed-point number with 8 fraction bits (85/64)."
  DAMAGE_FORMULA_LN_PREFACTOR:
    pos:
      EU: 0x20A1E70
      NA: 0x20A18EC
      JP: 0x20A2CC0
    size:
      NA: 0x4
      JP: 0x4
    doc: "The prefactor to the output of the ClampedLn in the damage formula, as a binary fixed-point number with 8 fraction bits (50)."
  DAMAGE_FORMULA_DEF_PREFACTOR:
    pos:
      EU: 0x20A1E74
      NA: 0x20A18F0
      JP: 0x20A2CC4
    size:
      NA: 0x4
      JP: 0x4
    doc: "The prefactor to the \"DEF\" (defense) intermediate quantity in the damage formula (see dungeon::last_move_damage_calc_def), as a binary fixed-point number with 8 fraction bits (-0.5)."
  DAMAGE_FORMULA_AT_PREFACTOR:
    pos:
      EU: 0x20A1E78
      NA: 0x20A18F4
      JP: 0x20A2CC8
    size:
      NA: 0x4
      JP: 0x4
    doc: "The prefactor to the \"AT\" (attack) intermediate quantity in the damage formula (see dungeon::last_move_damage_calc_at), as a binary fixed-point number with 8 fraction bits (153/256, which is close to 0.6)."
  DAMAGE_FORMULA_LN_ARG_PREFACTOR:
    pos:
      EU: 0x20A1E7C
      NA: 0x20A18F8
      JP: 0x20A2CCC
    size:
      NA: 0x4
      JP: 0x4
    doc: "The prefactor to the argument of ClampedLn in the damage formula (FLV + DAMAGE_FORMULA_FLV_SHIFT), as a binary fixed-point number with 8 fraction bits (10)."
  FORBIDDEN_FORGOT_MOVE_LIST:
    pos:
      EU: 0x20A1E9C
      NA: 0x20A1918
      JP: 0x20A2CEC
    size:
      EU: 0x12
      NA: 0x12
      JP: 0x12
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: struct forbidden_forgot_move_entry[3]
  TACTICS_UNLOCK_LEVEL_TABLE:
    pos:
      EU: 0x20A1EC4
      NA: 0x20A1940
      JP: 0x20A2D14
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "type: int16_t[12]"
  CLIENT_LEVEL_TABLE:
    pos:
      EU: 0x20A1EFC
      NA: 0x20A1978
      JP: 0x20A2D4C
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: |-
      Still a guess
      
      Note: unverified, ported from Irdkwia's notes
      
      type: int16_t[16]
  OUTLAW_LEVEL_TABLE:
    pos:
      EU: 0x20A1F1C
      NA: 0x20A1998
      JP: 0x20A2D6C
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: |-
      Table of 2-byte outlaw levels for outlaw missions, indexed by mission rank.
      
      type: int16_t[16]
  OUTLAW_MINION_LEVEL_TABLE:
    pos:
      EU: 0x20A1F3C
      NA: 0x20A19B8
      JP: 0x20A2D8C
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: |-
      Table of 2-byte outlaw minion levels for outlaw hideout missions, indexed by mission rank.
      
      type: int16_t[16]
  HIDDEN_POWER_BASE_POWER_TABLE:
    pos:
      EU: 0x20A1F5C
      NA: 0x20A19D8
      JP: 0x20A2DAC
    size:
      EU: 0x28
      NA: 0x28
      JP: 0x28
    doc: |-
      Still a guess
      
      Note: unverified, ported from Irdkwia's notes
      
      type: int[10]
  VERSION_EXCLUSIVE_MONSTERS:
    pos:
      EU: 0x20A1F84
      NA: 0x20A1A00
      JP: 0x20A2DD4
    size:
      EU: 0x5C
      NA: 0x5C
      JP: 0x5C
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: struct version_exclusive_monster[23]
  IQ_SKILL_RESTRICTIONS:
    pos:
      EU: 0x20A1FE0
      NA: 0x20A1A5C
      JP: 0x20A2E30
    size:
      EU: 0x8A
      NA: 0x8A
      JP: 0x8A
    doc: |-
      Table of 2-byte values for each IQ skill that represent a group. IQ skills in the same group can not be enabled at the same time.
      
      type: int16_t[69]
  SECONDARY_TERRAIN_TYPES:
    pos:
      EU: 0x20A206C
      NA: 0x20A1AE8
      JP: 0x20A2EBC
    size:
      EU: 0xC8
      NA: 0xC8
      JP: 0xC8
    doc: |-
      The type of secondary terrain for each dungeon in the game.
      
      This is an array of 200 bytes. Each byte is an enum corresponding to one dungeon.
      
      type: struct secondary_terrain_type_8[200]
  SENTRY_DUTY_MONSTER_IDS:
    pos:
      EU: 0x20A2134
      NA: 0x20A1BB0
      JP: 0x20A2F84
    size:
      EU: 0xCC
      NA: 0xCC
      JP: 0xCC
    doc: |-
      Table of monster IDs usable in the sentry duty minigame.
      
      type: struct monster_id_16[102]
  IQ_SKILLS:
    pos:
      EU: 0x20A2200
      NA: 0x20A1C7C
      JP: 0x20A3050
    size:
      EU: 0x114
      NA: 0x114
      JP: 0x114
    doc: |-
      Table of 4-byte values for each IQ skill that represent the required IQ value to unlock a skill.
      
      type: int[69]
  IQ_GROUP_SKILLS:
    pos:
      EU: 0x20A2314
      NA: 0x20A1D90
      JP: 0x20A3164
    size:
      EU: 0x190
      NA: 0x190
      JP: 0x190
    doc: "Irdkwia's notes: 25*16*0x1"
  MONEY_QUANTITY_TABLE:
    pos:
      EU: 0x20A24A4
      NA: 0x20A1F20
      JP: 0x20A32F4
    size:
      EU: 0x190
      NA: 0x190
      JP: 0x190
    doc: |-
      Table that maps money quantity codes (as recorded in, e.g., struct item) to actual amounts.
      
      type: int[100]
  ARM9_UNKNOWN_TABLE__NA_20A20B0:
    pos:
      EU: 0x20A2634
      NA: 0x20A20B0
      JP: 0x20A3484
    size:
      EU: 0x200
      NA: 0x200
      JP: 0x200
    doc: |-
      256*0x2
      
      Note: unverified, ported from Irdkwia's notes
  IQ_GUMMI_GAIN_TABLE:
    pos:
      EU: 0x20A2834
      NA: 0x20A22B0
      JP: 0x20A3684
    size:
      EU: 0x288
      NA: 0x288
      JP: 0x288
    doc: "type: int16_t[18][18]"
  GUMMI_BELLY_RESTORE_TABLE:
    pos:
      EU: 0x20A2ABC
      NA: 0x20A2538
      JP: 0x20A390C
    size:
      EU: 0x288
      NA: 0x288
      JP: 0x288
    doc: "type: int16_t[18][18]"
  BAG_CAPACITY_TABLE_SPECIAL_EPISODES:
    pos:
      EU: 0x20A2D44
      NA: 0x20A27C0
      JP: 0x20A3B94
    size:
      EU: 0x14
      NA: 0x14
      JP: 0x14
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: uint32_t[5]
  BAG_CAPACITY_TABLE:
    pos:
      EU: 0x20A2D58
      NA: 0x20A27D4
      JP: 0x20A3BA8
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: |-
      Array of 4-byte integers containing the bag capacity for each bag level.
      
      type: uint32_t[8]
  SPECIAL_EPISODE_MAIN_CHARACTERS:
    pos:
      EU: 0x20A2D78
      NA: 0x20A27F4
      JP: 0x20A3BC8
    size:
      EU: 0xC8
      NA: 0xC8
      JP: 0xC8
    doc: "type: struct monster_id_16[100]"
  GUEST_MONSTER_DATA:
    pos:
      EU: 0x20A2E40
      NA: 0x20A28BC
      JP: 0x20A3C90
    size:
      EU: 0x288
      NA: 0x288
      JP: 0x288
    doc: |-
      Data for guest monsters that join you during certain story dungeons.
      
      Array of 18 36-byte entries.
      
      See the struct definitions and Frostbyte's dungeon data document for more info.
      
      type: struct guest_monster[18]
  RANK_UP_TABLE:
    pos:
      EU: 0x20A30C8
      NA: 0x20A2B44
      JP: 0x20A3F18
    size:
      EU: 0xD0
      NA: 0xD0
      JP: 0xD0
  DS_DOWNLOAD_TEAMS:
    pos:
      EU: 0x20A3198
      NA: 0x20A2C14
      JP: 0x20A3FE8
    size:
      EU: 0x70
      NA: 0x70
      JP: 0x70
    doc: |-
      Seems like this is just a collection of null-terminated lists concatenated together.
      
      Note: unverified, ported from Irdkwia's notes
      
      struct monster_id_16[56]
  ARM9_UNKNOWN_PTR__NA_20A2C84:
    pos:
      EU: 0x20A3208
      NA: 0x20A2C84
      JP: 0x20A4058
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  UNOWN_SPECIES_ADDITIONAL_CHARS:
    pos:
      EU: 0x20A320C
      NA: 0x20A2C88
      JP: 0x20A405C
    size:
      EU: 0x80
      NA: 0x80
      JP: 0x80
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: enum monster_id[28]
  MONSTER_SPRITE_DATA:
    pos:
      EU: 0x20A332C
      NA: 0x20A2D08
      JP: 0x20A40DC
    size:
      EU: 0x4B0
      NA: 0x4B0
      JP: 0x4B0
    doc: Contains information about the sprite size and sprite file size of each monster
  REMOTE_STRINGS:
    pos:
      EU: 0x20A4140
      NA: 0x20A3B40
      JP: 0x20A4F24
    size:
      EU: 0x2C
      NA: 0x2C
      JP: 0x2C
    doc: "Note: unverified, ported from Irdkwia's notes"
  RANK_STRINGS_1:
    pos:
      EU: 0x20A416C
      NA: 0x20A3B6C
      JP: 0x20A4F60
    size:
      EU: 0x30
      NA: 0x30
      JP: 0x30
    doc: "Note: unverified, ported from Irdkwia's notes"
  MISSION_MENU_STRING_IDS_1:
    pos:
      EU: 0x20A419C
      NA: 0x20A3B9C
      JP: 0x20A4F50
    size:
      EU: 0x10
      NA: 0x10
      JP: 0x10
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int16_t[8]
  RANK_STRINGS_2:
    pos:
      EU: 0x20A41AC
      NA: 0x20A3BAC
      JP: 0x20A4F90
    size:
      EU: 0x30
      NA: 0x30
      JP: 0x30
    doc: "Note: unverified, ported from Irdkwia's notes"
  MISSION_MENU_STRING_IDS_2:
    pos:
      EU: 0x20A41DC
      NA: 0x20A3BDC
      JP: 0x20A4FC0
    size:
      EU: 0x10
      NA: 0x10
      JP: 0x10
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int16_t[8]
  RANK_STRINGS_3:
    pos:
      EU: 0x20A41EC
      NA: 0x20A3BEC
      JP: 0x20A4FD0
    size:
      EU: 0xB4
      NA: 0xB4
      JP: 0xB4
    doc: "Note: unverified, ported from Irdkwia's notes"
  MISSION_DUNGEON_UNLOCK_TABLE:
    pos:
      EU: 0x20A42AC
      NA: 0x20A3CAC
      JP: 0x20A5090
    size:
      EU: 0x6
      NA: 0x6
      JP: 0x6
    doc: |-
      Irdkwia's notes: SpecialDungeonMissions
      
      type: struct dungeon_unlock_entry[3]
  NO_SEND_ITEM_TABLE:
    pos:
      EU: 0x20A42B2
      NA: 0x20A3CB2
      JP: 0x20A5096
    size:
      EU: 0x6
      NA: 0x6
      JP: 0x6
    doc: |-
      A list of items that are forbidden from being used in a mission sent by Wonder Mail.
      
      type: struct item_id_16[3]
  ARM9_UNKNOWN_TABLE__NA_20A3CC8:
    pos:
      EU: 0x20A42C8
      NA: 0x20A3CC8
      JP: 0x20A50AC
    size:
      EU: 0x1C
      NA: 0x1C
      JP: 0x1C
    doc: |-
      14*0x2
      Linked to ARM9_UNKNOWN_TABLE__NA_20A3CE4
      
      Note: unverified, ported from Irdkwia's notes
  ARM9_UNKNOWN_TABLE__NA_20A3CE4:
    pos:
      EU: 0x20A42E4
      NA: 0x20A3CE4
      JP: 0x20A50C8
    size:
      EU: 0x10
      NA: 0x10
      JP: 0x10
    doc: |-
      8*0x2
      
      Note: unverified, ported from Irdkwia's notes
  ARM9_UNKNOWN_FUNCTION_TABLE__NA_20A3CF4:
    pos:
      EU: 0x20A42F4
      NA: 0x20A3CF4
      JP: 0x20A50D8
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: |-
      Could be related to missions
      
      Note: unverified, ported from Irdkwia's notes
  MISSION_BANNED_STORY_MONSTERS:
    pos:
      EU: 0x20A4314
      NA: 0x20A3D14
      JP: 0x20A50F8
    size:
      EU: 0x2A
      NA: 0x2A
      JP: 0x2A
    doc: |-
      Null-terminated list of monster IDs that can't be used (probably as clients or targets) when generating missions before a certain point in the story.
      
      To be precise, PERFOMANCE_PROGRESS_FLAG[9] must be enabled so these monsters can appear as mission clients.
      
      type: struct monster_id_16[length / 2]
  ITEM_DELIVERY_TABLE:
    pos:
      EU: 0x20A433E
      NA: 0x20A3D3E
      JP: 0x20A5122
    size:
      EU: 0x2E
      NA: 0x2E
      JP: 0x2E
    doc: |-
      A list of valid items used for delivering an item for a mission client.
      
      type: struct item_id_16[23]
  MISSION_RANK_POINTS:
    pos:
      EU: 0x20A436C
      NA: 0x20A3D6C
      JP: 0x20A5150
    size:
      EU: 0x40
      NA: 0x40
      JP: 0x40
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int[16]
  MISSION_BANNED_MONSTERS:
    pos:
      EU: 0x20A43AC
      NA: 0x20A3DAC
      JP: 0x20A5190
    size:
      EU: 0xF8
      NA: 0xF8
      JP: 0xF8
    doc: |-
      Null-terminated list of monster IDs that can't be used (probably as clients or targets) when generating missions.
      
      type: struct monster_id_16[124]
  MISSION_STRING_IDS:
    pos:
      EU: 0x20A44A4
      NA: 0x20A3EA4
      JP: 0x20A5288
    size:
      EU: 0x788
      NA: 0x788
      JP: 0x788
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int16_t[964]
  LEVEL_LIST:
    pos:
      EU: 0x20A4CEC
      NA: 0x20A46EC
      JP: 0x20A5AD0
    size:
      EU: 0x2470
      NA: 0x21D0
      JP: 0x2234
    doc: "Note: unverified, ported from Irdkwia's notes"
  EVENTS:
    pos:
      EU: 0x20A5BD8
      NA: 0x20A5488
      JP: 0x20A6894
    size:
      EU: 0x1584
      NA: 0x1434
      JP: 0x1470
    doc: |-
      Table of levels for the script engine, in which scenes can take place. There are a version-dependent number of 12-byte entries.
      
      type: struct script_level[length / 12]
  ARM9_UNKNOWN_TABLE__NA_20A68BC:
    pos:
      EU: 0x20A715C
      NA: 0x20A68BC
      JP: 0x20A7D04
    size:
      EU: 0xC
      NA: 0xC
      JP: 0xC
    doc: |-
      6*0x2
      
      Note: unverified, ported from Irdkwia's notes
  DEMO_TEAMS:
    pos:
      EU: 0x20A7168
      NA: 0x20A68C8
      JP: 0x20A7D10
    size:
      EU: 0x48
      NA: 0x48
      JP: 0x48
    doc: |-
      18*0x4 (Hero ID 0x2, Partner ID 0x2)
      
      Note: unverified, ported from Irdkwia's notes
  ACTOR_LIST:
    pos:
      EU: 0x20A71B0
      NA: 0x20A6910
      JP: 0x20A7D58
    size:
      EU: 0x28F8
      NA: 0x28F8
      JP: 0x28F8
    doc: "Note: unverified, ported from Irdkwia's notes"
  ENTITIES:
    pos:
      EU: 0x20A8890
      NA: 0x20A7FF0
      JP: 0x20A9438
    size:
      EU: 0x1218
      NA: 0x1218
      JP: 0x1218
    doc: |-
      Table of entities for the script engine, which can move around and do things within a scene. There are 386 12-byte entries.
      
      type: struct script_entity[386]
  JOB_WINDOW_PARAMS_1:
    pos:
      EU: 0x20A9AB8
      NA: 0x20A9218
      JP: 0x20AA660
    size:
      EU: 0x10
      NA: 0x10
      JP: 0x10
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_1:
    pos:
      EU: 0x20A9AC8
      NA: 0x20A9228
      JP: 0x20AA670
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_2:
    pos:
      EU: 0x20A9AE8
      NA: 0x20A9248
      JP: 0x20AA690
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_3:
    pos:
      EU: 0x20A9B58
      NA: 0x20A92B8
      JP: 0x20AA700
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_4:
    pos:
      EU: 0x20A9B70
      NA: 0x20A92D0
      JP: 0x20AA718
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_5:
    pos:
      EU: 0x20A9B88
      NA: 0x20A92E8
      JP: 0x20AA730
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_6:
    pos:
      EU: 0x20A9BA0
      NA: 0x20A9300
      JP: 0x20AA748
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_7:
    pos:
      EU: 0x20A9BB8
      NA: 0x20A9318
      JP: 0x20AA760
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_8:
    pos:
      EU: 0x20A9BD0
      NA: 0x20A9330
      JP: 0x20AA778
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_9:
    pos:
      EU: 0x20A9BE8
      NA: 0x20A9348
      JP: 0x20AA790
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_10:
    pos:
      EU: 0x20A9C00
      NA: 0x20A9360
      JP: 0x20AA7A8
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_11:
    pos:
      EU: 0x20A9C18
      NA: 0x20A9378
      JP: 0x20AA7C0
    size:
      EU: 0x18
      NA: 0x18
      JP: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_12:
    pos:
      EU: 0x20A9C30
      NA: 0x20A9390
      JP: 0x20AA7D8
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_MENU_ITEMS_13:
    pos:
      EU: 0x20A9C50
      NA: 0x20A93B0
      JP: 0x20AA7F8
    size:
      EU: 0x20
      NA: 0x20
      JP: 0x20
    doc: "Note: unverified, ported from Irdkwia's notes"
  JOB_WINDOW_PARAMS_2:
    pos:
      EU: 0x20A9C70
      NA: 0x20A93D0
      JP: 0x20AA818
    size:
      EU: 0x10
      NA: 0x10
      JP: 0x10
    doc: "Note: unverified, ported from Irdkwia's notes"
  DUNGEON_SWAP_ID_TABLE:
    pos:
      EU: 0x20A9C80
      NA: 0x20A93E0
      JP: 0x20AA828
    size:
      EU: 0xD4
      NA: 0xD4
      JP: 0xD4
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: struct dungeon_id_8[212]
  MAP_MARKER_PLACEMENTS:
    pos:
      EU: 0x20A9D70
      NA: 0x20A94D0
      JP: 0x20AA918
    size:
      EU: 0x9B0
      NA: 0x9B0
      JP: 0x9B0
    doc: |-
      The map marker position of each dungeon on the Wonder Map.
      
      This is an array of 310 map marker structs. Each entry is 8 bytes, and contains positional information about a dungeon on the map.
      
      See the struct definitions and Frostbyte's dungeon data document for more info.
      
      type: struct map_marker[310]
  LFO_OUTPUT_VOICE_UPDATE_FLAGS:
    pos:
      EU: 0x20AA840
      NA: 0x20A9FA0
      JP: 0x20AB3E8
    size:
      EU: 0x10
      NA: 0x10
  TRIG_TABLE:
    pos:
      EU: 0x20AA850
      NA: 0x20A9FB0
      JP: 0x20AB3F8
    size:
      EU: 0x4974
      NA: 0x4974
      JP: 0x4974
    doc: |-
      Interleaved table of sine and cosine values at 4096 divisions over a full period (2π radians).
      
      More precisely, the trig_values entry at index i corresponds to {sin(i * 2π/4096), cos(i * 2π/4096)} (each division is ~1/10 of a degree). Values are stored as signed fixed-point numbers with 12 fraction bits.
      
      type: struct trig_values[4096]
  FX_ATAN_IDX_TABLE:
    pos:
      EU: 0x20AE850
      NA: 0x20ADFB0
      JP: 0x20AF3F8
    size:
      EU: 0x102
      NA: 0x102
      JP: 0x102
    doc: |-
      Table of arctangent values at 129 divisions over the domain [0, 1].
      
      More precisely, entry at index i corresponds to (atan(i/128) / (π/2)). Values are stored as signed fixed-point numbers with 14 fraction bits.
  TEX_PLTT_START_ADDR_TABLE:
    pos:
      EU: 0x20AE954
      NA: 0x20AE0B4
      JP: 0x20AF4FC
    size:
      EU: 0x10
      NA: 0x10
  TEX_START_ADDR_TABLE:
    pos:
      EU: 0x20AE964
      NA: 0x20AE0C4
      JP: 0x20AF50C
    size:
      EU: 0x60
      NA: 0x60
  ARM9_UNKNOWN_TABLE__NA_20AE924:
    pos:
      EU: 0x20AF1C4
      NA: 0x20AE924
      JP: 0x20AFD6C
    size:
      EU: 0x2D4
      NA: 0x2D4
      JP: 0x2D4
    doc: |-
      724*0x1
      
      Note: unverified, ported from Irdkwia's notes
  MEMORY_ALLOCATION_ARENA_GETTERS:
    pos:
      EU: 0x20AF7A0
      NA: 0x20AEF00
      JP: 0x20B0340
    size:
      EU: 0x8
      NA: 0x8
    doc: |-
      Functions to get the desired memory arena for allocating and freeing heap memory.
      
      type: struct mem_arena_getters
  PRNG_SEQUENCE_NUM:
    pos:
      EU: 0x20AF7CC
      NA: 0x20AEF2C
      JP: 0x20B036C
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: "[Runtime] The current PRNG sequence number for the general-purpose PRNG. See Rand16Bit for more information on how the general-purpose PRNG works."
  LOADED_OVERLAY_GROUP_0:
    pos:
      EU: 0x20AFAD0
      NA: 0x20AF230
      JP: 0x20B0670
    size:
      EU: 0x4
      NA: 0x4
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
  LOADED_OVERLAY_GROUP_1:
    pos:
      EU: 0x20AFAD4
      NA: 0x20AF234
      JP: 0x20B0674
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: |-
      [Runtime] The overlay group ID of the overlay currently loaded in slot 1. A group ID of 0 denotes no overlay.
      
      Overlay group IDs that can be loaded in slot 1:
      - 0x4 (overlay 1)
      - 0x5 (overlay 2)
      - 0xD (overlay 11)
      - 0xE (overlay 29)
      - 0xF (overlay 34)
      
      type: enum overlay_group_id
  LOADED_OVERLAY_GROUP_2:
    pos:
      EU: 0x20AFAD8
      NA: 0x20AF238
    size:
      EU: 0x4
      NA: 0x4
    doc: |-
      [Runtime] The overlay group ID of the overlay currently loaded in slot 2. A group ID of 0 denotes no overlay.
      
      Overlay group IDs that can be loaded in slot 2:
      - 0x1 (overlay 0)
      - 0x2 (overlay 10)
      - 0x3 (overlay 35)
      
      type: enum overlay_group_id
  DEBUG_IS_INITIALIZED:
    pos:
      EU: 0x20AFF50
      NA: 0x20AF698
      JP: 0x20B0AD8
    size:
      NA: 0x1
  PACK_FILES_OPENED:
    aliases:
      - DIRECTORY_FILES_EXTRACTED
    pos:
      EU: 0x20AFF54
      NA: 0x20AF69C
      JP: 0x20B0ADC
    size:
      EU: 0x4
      NA: 0x4
    doc: |-
      [Runtime] A pointer to the 6 opened Pack files (listed at PACK_FILE_PATHS_TABLE)
      
      type: struct pack_file_opened*
  PACK_FILE_PATHS_TABLE:
    aliases:
      - DIRECTORY_FILE_TABLE
    pos:
      EU: 0x20AFF58
      NA: 0x20AF6A0
      JP: 0x20B0AE0
    size:
      EU: 0x18
      NA: 0x18
    doc: |-
      List of pointers to path strings to all known pack files.
      The game uses this table to load its resources when launching dungeon mode.
      
      type: char*[6]
  GAME_STATE_VALUES:
    pos:
      EU: 0x20AFF70
      NA: 0x20AF6B8
      JP: 0x20B0AF8
    doc: "[Runtime]"
  BAG_ITEMS_PTR_MIRROR:
    pos:
      EU: 0x20AFF70
      NA: 0x20AF6B8
      JP: 0x20B0AF8
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: |-
      [Runtime] Probably a mirror of ram.yml::BAG_ITEMS_PTR?
      
      Note: unverified, ported from Irdkwia's notes
  ITEM_DATA_TABLE_PTRS:
    pos:
      EU: 0x20AFF78
      NA: 0x20AF6C0
      JP: 0x20B0B00
    size:
      EU: 0xC
      NA: 0xC
    doc: |-
      [Runtime] List of pointers to various item data tables.
      
      The first two pointers are definitely item-related (although the order appears to be flipped between EU/NA?). Not sure about the third pointer.
  DUNGEON_MOVE_TABLES:
    pos:
      EU: 0x20AFFA8
      NA: 0x20AF6DC
      JP: 0x20B0B1C
    doc: "[Runtime] Seems to be some sort of region (a table of tables?) that holds pointers to various important tables related to moves."
  MOVE_DATA_TABLE_PTR:
    pos:
      EU: 0x20AFFB0
      NA: 0x20AF6E4
    size:
      EU: 0x4
      NA: 0x4
    doc: |-
      [Runtime] Points to the contents of the move data table loaded from waza_p.bin
      
      type: struct move_data_table*
  WAN_TABLE:
    pos:
      EU: 0x20B0524
      NA: 0x20AFC68
      JP: 0x20B10A8
    size:
      NA: 0x4
    doc: |-
      pointer to the list of wan sprite loaded in RAM
      
      struct wan_table*
  RENDER_3D:
    pos:
      EU: 0x20B0540
      NA: 0x20AFC80
      JP: 0x20B10C0
    size:
      EU: 0x44
      NA: 0x44
    doc: |-
      The (seemingly) unique instance render_3d_global in the game
      
      type: struct render_3d_global
  RENDER_3D_FUNCTIONS_64:
    pos:
      EU: 0x20B0584
      NA: 0x20AFCC4
      JP: 0x20B1104
    size:
      EU: 0x20
      NA: 0x20
    doc: |-
      Pointers to the 8 functions available for rendering a render_3d_element_64
      
      type: render_3d_element_64_fn_t[8]
  LANGUAGE_INFO_DATA:
    pos:
      EU: 0x20B05A8
      NA: 0x20AFCE8
      JP: 0x20B1128
    doc: "[Runtime]"
  TBL_TALK_GROUP_STRING_ID_START:
    pos:
      EU: 0x20B0614
      NA: 0x20AFCF8
      JP: 0x20B1140
    size:
      NA: 0xC
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int16_t[6]
  KEYBOARD_STRING_IDS:
    pos:
      EU: 0x20B0718
      NA: 0x20AFDFC
      JP: 0x20B1240
    size:
      EU: 0x3C
      NA: 0x3C
      JP: 0x3C
    doc: |-
      30*0x2
      
      Note: unverified, ported from Irdkwia's notes
      
      type: int16_t[30]
  NOTIFY_NOTE:
    pos:
      EU: 0x20B0814
      NA: 0x20AFEF8
      JP: 0x20B176C
    size:
      EU: 0x1
      NA: 0x1
      JP: 0x1
    doc: |-
      [Runtime] Flag related to saving and loading state?
      
      type: bool
  DEFAULT_HERO_ID:
    pos:
      EU: 0x20B0818
      NA: 0x20AFEFC
      JP: 0x20B1770
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: |-
      The default monster ID for the hero (0x4: Charmander)
      
      type: struct monster_id_16
  DEFAULT_PARTNER_ID:
    pos:
      EU: 0x20B081A
      NA: 0x20AFEFE
      JP: 0x20B1772
    size:
      EU: 0x2
      NA: 0x2
      JP: 0x2
    doc: |-
      The default monster ID for the partner (0x1: Bulbasaur)
      
      type: struct monster_id_16
  GAME_MODE:
    pos:
      EU: 0x20B088C
      NA: 0x20AFF70
      JP: 0x20B17E4
    size:
      EU: 0x1
      NA: 0x1
      JP: 0x1
    doc: |-
      [Runtime] Game mode, see enum game_mode for possible values.
      
      type: uint8_t
  GLOBAL_PROGRESS_PTR:
    pos:
      EU: 0x20B0890
      NA: 0x20AFF74
      JP: 0x20B17E8
    size:
      EU: 0x4
      NA: 0x4
    doc: |-
      [Runtime]
      
      type: struct global_progress*
  ADVENTURE_LOG_PTR:
    pos:
      EU: 0x20B0894
      NA: 0x20AFF78
      JP: 0x20B17EC
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: |-
      [Runtime]
      
      type: struct adventure_log*
  ITEM_TABLES_PTRS_1:
    pos:
      EU: 0x20B1264
      NA: 0x20B0948
      JP: 0x20B21BC
    size:
      EU: 0x68
      NA: 0x68
      JP: 0x68
    doc: "Irdkwia's notes: 26*0x4, uses MISSION_FLOOR_RANKS_AND_ITEM_LISTS"
  UNOWN_SPECIES_ADDITIONAL_CHAR_PTR_TABLE:
    pos:
      EU: 0x20B131C
      NA: 0x20B09D8
      JP: 0x20B224C
    size:
      EU: 0x70
      NA: 0x70
      JP: 0x70
    doc: |-
      Uses UNOWN_SPECIES_ADDITIONAL_CHARS
      
      Note: unverified, ported from Irdkwia's notes
      
      type: enum monster_id*[28]
  TEAM_MEMBER_TABLE_PTR:
    pos:
      EU: 0x20B138C
      NA: 0x20B0A48
      JP: 0x20B22BC
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: Pointer to TEAM_MEMBER_TABLE
  MISSION_DELIVER_LIST_PTR:
    pos:
      EU: 0x20B13A4
      NA: 0x20B0A60
      JP: 0x20B22D4
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: A pointer to a heap-allocated list of items usable for delivery missions
  MISSION_DELIVER_COUNT:
    pos:
      EU: 0x20B13A8
      NA: 0x20B0A64
      JP: 0x20B22D8
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: The total number of items usable for delivery missions
  MISSION_DUNGEON_LIST_PTR:
    pos:
      EU: 0x20B13AC
      NA: 0x20B0A68
      JP: 0x20B22DC
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: A pointer to a heap-allocated list of dungeons usable for missions
  MISSION_DUNGEON_COUNT:
    pos:
      EU: 0x20B13B0
      NA: 0x20B0A6C
      JP: 0x20B22E0
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: The total number of dungeons usable for missions
  MISSION_MONSTER_LIST_PTR:
    pos:
      EU: 0x20B13B4
      NA: 0x20B0A70
      JP: 0x20B22E4
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: A pointer to a heap-allocated list of monsters usable for missions
  MISSION_MONSTER_COUNT:
    pos:
      EU: 0x20B13B8
      NA: 0x20B0A74
      JP: 0x20B22E8
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: The total number of monsters usable for missions
  MISSION_LIST_PTR:
    pos:
      EU: 0x20B13BC
      NA: 0x20B0A78
      JP: 0x20B22EC
    size:
      EU: 0x4
      NA: 0x4
      JP: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  REMOTE_STRING_PTR_TABLE:
    pos:
      EU: 0x20B13C0
      NA: 0x20B0A7C
      JP: 0x20B22F0
    size:
      EU: 0x1C
      NA: 0x1C
      JP: 0x1C
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: const char*[7]
  RANK_STRING_PTR_TABLE:
    pos:
      EU: 0x20B13DC
      NA: 0x20B0A98
      JP: 0x20B230C
    size:
      EU: 0x40
      NA: 0x40
      JP: 0x40
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: const char*[16]
  SMD_EVENTS_FUN_TABLE:
    pos:
      EU: 0x20B14D4
      NA: 0x20B0B90
      JP: 0x20B2404
    size:
      EU: 0x1FC
      NA: 0x1FC
    doc: |-
      Table of all DSE events, see https://projectpokemon.org/docs/mystery-dungeon-nds/procyon-studios-digital-sound-elements-r12/
      
      Irdkwia's notes: named DSEEventFunctionPtrTable with length 0x3C0 (note the disagreement), 240*0x4.
  MUSIC_DURATION_LOOKUP_TABLE_1:
    pos:
      EU: 0x20B1894
      NA: 0x20B0F50
      JP: 0x20B27C4
    size:
      EU: 0x100
      NA: 0x100
      JP: 0x100
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int16_t[128]
  MUSIC_DURATION_LOOKUP_TABLE_2:
    pos:
      EU: 0x20B1994
      NA: 0x20B1050
      JP: 0x20B28C4
    size:
      EU: 0x200
      NA: 0x200
      JP: 0x200
    doc: |-
      Note: unverified, ported from Irdkwia's notes
      
      type: int32_t[128]
  LFO_WAVEFORM_CALLBACKS:
    pos:
      EU: 0x20B1B94
      NA: 0x20B1250
      JP: 0x20B2AC4
    size:
      EU: 0x40
      NA: 0x40
  IS_DISP_ON:
    pos:
      EU: 0x20B34D8
      NA: 0x20B2B94
      JP: 0x20B4408
    size:
      EU: 0x1
      NA: 0x1
  GXI_DMA_ID:
    pos:
      EU: 0x20B34DC
      NA: 0x20B2B98
      JP: 0x20B440C
    size:
      EU: 0x4
      NA: 0x4
