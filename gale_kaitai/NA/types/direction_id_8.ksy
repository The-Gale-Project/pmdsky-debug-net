doc: Holds bitsized data for the parent enum direction_id.
meta:
  id: direction_id_8
  endian: le
  bit-endian: le
seq:
- id: direction_id_8_value
  type: b8
  enum: direction_id_8_enum
enums:
  direction_id_8_enum:
    -1: dir_none
    0: dir_down
    1: dir_down_right
    2: dir_right
    3: dir_up_right
    4: dir_up
    5: dir_up_left
    6: dir_left
    7: dir_down_left
    8: dir_current
