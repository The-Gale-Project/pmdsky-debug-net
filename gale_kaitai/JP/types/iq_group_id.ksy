doc: Holds the data for the enum iq_group_id.
meta:
  id: iq_group_id
  endian: le
  bit-endian: le
seq:
- id: iq_group_id_value
  type: b32
  enum: iq_group_id_enum
enums:
  iq_group_id_enum:
    0: iq_group_a
    1: iq_group_b
    2: iq_group_c
    3: iq_group_d
    4: iq_group_e
    5: iq_group_f
    6: iq_group_g
    7: iq_group_h
    8: iq_group_unused_0x8
    9: iq_group_unused_0x9
    10: iq_group_i
    11: iq_group_j
    12: iq_group_unused_0xc
    13: iq_group_unused_0xd
    14: iq_group_unused_0xe
    15: iq_group_none
