doc: Holds the data for the enum mission_subtype_take_item.
meta:
  id: mission_subtype_take_item
  endian: le
  bit-endian: le
seq:
- id: mission_subtype_take_item_value
  type: b32
  enum: mission_subtype_take_item_enum
enums:
  mission_subtype_take_item_enum:
    0: mission_take_item_normal_outlaw
    1: mission_take_item_hidden_outlaw
    2: mission_take_item_fleeing_outlaw
