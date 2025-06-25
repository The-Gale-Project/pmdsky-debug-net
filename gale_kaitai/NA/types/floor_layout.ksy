doc: Holds the data for the enum floor_layout.
meta:
  id: floor_layout
  endian: le
  bit-endian: le
seq:
- id: floor_layout_value
  type: b32
  enum: floor_layout_enum
enums:
  floor_layout_enum:
    0: layout_large
    1: layout_small
    2: layout_one_room_monster_house
    3: layout_outer_ring
    4: layout_crossroads
    5: layout_two_rooms_with_monster_house
    6: layout_line
    7: layout_cross
    8: layout_large_0x8
    9: layout_beetle
    10: layout_outer_rooms
    11: layout_medium
    12: layout_unused_0xc
    13: layout_unused_0xd
    14: layout_unused_0xe
    15: layout_unused_0xf
