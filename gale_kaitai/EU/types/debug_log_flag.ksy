doc: Holds the data for the enum debug_log_flag.
meta:
  id: debug_log_flag
  endian: le
  bit-endian: le
seq:
- id: debug_log_flag_value
  type: b32
  enum: debug_log_flag_enum
enums:
  debug_log_flag_enum:
    0: debug_log_flag_dungeon
    1: debug_log_flag_ground
    2: debug_log_flag_script
    3: debug_log_flag_script_debug
    4: debug_log_flag_script_supervision
    5: debug_log_flag_script_command
    6: debug_log_flag_sound
    7: debug_log_flag_bgm
    8: debug_log_flag_se
    10: debug_log_flag_flag
    11: debug_log_flag_file
    12: debug_log_flag_memory
    13: debug_log_flag_backup
    14: debug_log_flag_thread
    15: debug_log_flag_kernel
    16: debug_log_flag_performance
