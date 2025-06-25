doc: Holds bitsized data for the parent enum mission_reward_type.
meta:
  id: mission_reward_type_8
  endian: le
  bit-endian: le
seq:
- id: mission_reward_type_8_value
  type: b8
  enum: mission_reward_type_8_enum
enums:
  mission_reward_type_8_enum:
    0: mission_reward_money
    1: mission_reward_money_and_more
    2: mission_reward_item
    3: mission_reward_item_and_more
    4: mission_reward_exclusive_item
    5: mission_reward_money_hidden
    6: mission_reward_special
