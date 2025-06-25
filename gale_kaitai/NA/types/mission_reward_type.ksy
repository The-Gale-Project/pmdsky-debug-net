doc: Holds the data for the enum mission_reward_type.
meta:
  id: mission_reward_type
  endian: le
  bit-endian: le
seq:
- id: mission_reward_type_value
  type: b32
  enum: mission_reward_type_enum
enums:
  mission_reward_type_enum:
    0: mission_reward_money
    1: mission_reward_money_and_more
    2: mission_reward_item
    3: mission_reward_item_and_more
    4: mission_reward_exclusive_item
    5: mission_reward_money_hidden
    6: mission_reward_special
