doc: Holds the data for the enum animation_speed.
meta:
  id: animation_speed
  endian: le
  bit-endian: le
seq:
- id: animation_speed_value
  type: b32
  enum: animation_speed_enum
enums:
  animation_speed_enum:
    0: animation_speed_normal
    1: animation_speed_slow
    2: animation_speed_fast
    3: animation_speed_freeze
