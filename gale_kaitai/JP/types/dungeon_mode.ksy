doc: Holds the data for the enum dungeon_mode.
meta:
  id: dungeon_mode
  endian: le
  bit-endian: le
seq:
- id: dungeon_mode_value
  type: b32
  enum: dungeon_mode_enum
enums:
  dungeon_mode_enum:
    0: dmode_closed
    1: dmode_open
    2: dmode_request
    3: dmode_open_and_request
