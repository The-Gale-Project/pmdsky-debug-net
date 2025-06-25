doc: Holds the data for the enum game_mode.
meta:
  id: game_mode
  endian: le
  bit-endian: le
seq:
- id: game_mode_value
  type: b32
  enum: game_mode_enum
enums:
  game_mode_enum:
    0: game_mode_menu
    1: game_mode_1
    2: game_mode_normal
    3: game_mode_special_episode
    4: game_mode_rescue
    5: game_mode_5
