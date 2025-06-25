doc: Holds the data for the enum mission_rank.
meta:
  id: mission_rank
  endian: le
  bit-endian: le
seq:
- id: mission_rank_value
  type: b32
  enum: mission_rank_enum
enums:
  mission_rank_enum:
    1: mission_rank_e
    2: mission_rank_d
    3: mission_rank_c
    4: mission_rank_b
    5: mission_rank_a
    6: mission_rank_s
    7: mission_rank_1_star
    8: mission_rank_2_star
    9: mission_rank_3_star
    10: mission_rank_4_star
    11: mission_rank_5_star
    12: mission_rank_6_star
    13: mission_rank_7_star
    14: mission_rank_8_star
    15: mission_rank_9_star
