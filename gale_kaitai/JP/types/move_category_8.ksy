doc: Holds bitsized data for the parent enum move_category.
meta:
  id: move_category_8
  endian: le
  bit-endian: le
seq:
- id: move_category_8_value
  type: b8
  enum: move_category_8_enum
enums:
  move_category_8_enum:
    0: category_physical
    1: category_special
    2: category_status
    3: category_none
