doc: Holds bitsized data for the parent enum move_range.
meta:
  id: move_range_4
  endian: le
  bit-endian: le
seq:
- id: move_range_4_value
  type: b4
  enum: move_range_4_enum
enums:
  move_range_4_enum:
    0: range_front
    1: range_front_and_sides
    2: range_nearby
    3: range_room
    4: range_front_2
    5: range_front_10
    6: range_floor
    7: range_user
    8: range_front_with_corner_cutting
    9: range_front_2_with_corner_cutting
    15: range_special
