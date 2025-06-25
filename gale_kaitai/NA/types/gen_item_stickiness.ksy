doc: Holds the data for the enum gen_item_stickiness.
meta:
  id: gen_item_stickiness
  endian: le
  bit-endian: le
seq:
- id: gen_item_stickiness_value
  type: b32
  enum: gen_item_stickiness_enum
enums:
  gen_item_stickiness_enum:
    0: gen_item_sticky_random
    1: gen_item_sticky_always
    2: gen_item_sticky_never
