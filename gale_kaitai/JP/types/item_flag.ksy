doc: Holds the data for the enum item_flag.
meta:
  id: item_flag
  endian: le
  bit-endian: le
seq:
- id: item_flag_value
  type: b32
  enum: item_flag_enum
enums:
  item_flag_enum:
    0: item_flag_consumable
    1: item_flag_throwable_at_ally
    2: item_flag_throwable_at_enemy
