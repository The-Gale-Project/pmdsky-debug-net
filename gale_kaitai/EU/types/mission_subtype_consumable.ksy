doc: Holds the data for the enum mission_subtype_consumable.
meta:
  id: mission_subtype_consumable
  endian: le
  bit-endian: le
seq:
- id: mission_subtype_consumable_value
  type: b32
  enum: mission_subtype_consumable_enum
enums:
  mission_subtype_consumable_enum:
    0: mission_consumable_unk_0
    1: mission_seven_treasure
    2: mission_special_episode
