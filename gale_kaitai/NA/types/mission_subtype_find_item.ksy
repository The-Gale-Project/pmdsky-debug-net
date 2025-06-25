doc: Holds the data for the enum mission_subtype_find_item.
meta:
  id: mission_subtype_find_item
  endian: le
  bit-endian: le
seq:
- id: mission_subtype_find_item_value
  type: b32
  enum: mission_subtype_find_item_enum
enums:
  mission_subtype_find_item_enum:
    0: mission_find_item_common_table
    1: mission_find_item_rare_table
    2: mission_find_item_evolves_client
    3: mission_find_item_client_favorite_gummi
    4: mission_togetic_gabite_scale
