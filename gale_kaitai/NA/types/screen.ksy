doc: Holds the data for the enum screen.
meta:
  id: screen
  endian: le
  bit-endian: le
seq:
- id: screen_value
  type: b32
  enum: screen_enum
enums:
  screen_enum:
    0: screen_main
    1: screen_sub
