doc: Holds the data for the enum item_list_type.
meta:
  id: item_list_type
  endian: le
  bit-endian: le
seq:
- id: item_list_type_value
  type: b32
  enum: item_list_type_enum
enums:
  item_list_type_enum:
    0: item_list_regular
    1: item_list_shop
    2: item_list_monster_house
    3: item_list_buried
    4: item_list_bazaar
    5: item_list_secret_room
