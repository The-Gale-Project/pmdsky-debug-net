doc: Holds the data for the enum item_category.
meta:
  id: item_category
  endian: le
  bit-endian: le
seq:
- id: item_category_value
  type: b32
  enum: item_category_enum
enums:
  item_category_enum:
    0: category_thrown_line
    1: category_thrown_arc
    2: category_berries_seeds_vitamins
    3: category_food_gummies
    4: category_held_items
    5: category_tms_hms
    6: category_poke
    7: category_unk_7
    8: category_other
    9: category_orbs
    10: category_link_box
    11: category_used_tm
    12: category_treasure_boxes_1
    13: category_treasure_boxes_2
    14: category_treasure_boxes_3
    15: category_exclusive_items
