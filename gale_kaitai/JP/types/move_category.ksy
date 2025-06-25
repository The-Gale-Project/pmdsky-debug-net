doc: Holds the data for the enum move_category.
meta:
  id: move_category
  endian: le
  bit-endian: le
seq:
- id: move_category_value
  type: b32
  enum: move_category_enum
enums:
  move_category_enum:
    0: category_physical
    1: category_special
    2: category_status
    3: category_none
