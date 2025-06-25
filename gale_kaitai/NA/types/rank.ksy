doc: Holds the data for the enum rank.
meta:
  id: rank
  endian: le
  bit-endian: le
seq:
- id: rank_value
  type: b32
  enum: rank_enum
enums:
  rank_enum:
    0: rank_normal
    1: rank_bronze
    2: rank_silver
    3: rank_gold
    4: rank_diamond
    5: rank_super
    6: rank_ultra
    7: rank_hyper
    8: rank_master
    9: rank_master_1_star
    10: rank_master_2_stars
    11: rank_master_3_stars
    12: rank_guildmaster
