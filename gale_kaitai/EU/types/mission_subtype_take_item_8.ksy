doc: Holds bitsized data for the parent enum mission_subtype_take_item.
meta:
  id: mission_subtype_take_item_8
  endian: le
  bit-endian: le
seq:
- id: mission_subtype_take_item_8_value
  type: b8
  enum: mission_subtype_take_item_8_enum
enums:
  mission_subtype_take_item_8_enum:
    0: mission_take_item_normal_outlaw
    1: mission_take_item_hidden_outlaw
    2: mission_take_item_fleeing_outlaw
