doc: Holds the data for the enum top_screen_fade_status.
meta:
  id: top_screen_fade_status
  endian: le
  bit-endian: le
seq:
- id: top_screen_fade_status_value
  type: b32
  enum: top_screen_fade_status_enum
enums:
  top_screen_fade_status_enum:
    0: top_screen_fade_0x0
    1: top_screen_fade_0x1
    2: top_screen_fade_black
    3: top_screen_fade_0x3
    4: top_screen_fade_fade_in
    5: top_screen_fade_no_fade
    6: top_screen_fade_fade_out
