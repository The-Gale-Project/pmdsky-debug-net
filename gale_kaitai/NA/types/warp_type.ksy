doc: Holds the data for the enum warp_type.
meta:
  id: warp_type
  endian: le
  bit-endian: le
seq:
- id: warp_type_value
  type: b32
  enum: warp_type_enum
enums:
  warp_type_enum:
    0: warp_random
    1: warp_stairs_2
    2: warp_position_fuzzy
    3: warp_position_exact
    4: warp_stairs_3
    5: warp_leader
