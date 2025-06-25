doc: Holds the data for the enum debug_flag.
meta:
  id: debug_flag
  endian: le
  bit-endian: le
seq:
- id: debug_flag_value
  type: b32
  enum: debug_flag_enum
enums:
  debug_flag_enum:
    0: debug_flag_text_speedup
    1: debug_flag_no_screen_fade
    2: debug_flag_sound_off
    3: debug_flag_bgm_off
    4: debug_flag_se_off
    5: debug_flag_stage_npc_dummy
    6: debug_flag_text_limit_check
    7: debug_flag_no_cheat_check
    8: debug_flag_no_plunge_check
    9: debug_flag_dungeon_infinite_comeback
    10: debug_flag_general_debug
    11: debug_flag_edit_mode
