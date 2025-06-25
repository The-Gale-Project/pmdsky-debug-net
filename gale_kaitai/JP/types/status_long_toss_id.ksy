doc: Holds the data for the enum status_long_toss_id.
meta:
  id: status_long_toss_id
  endian: le
  bit-endian: le
seq:
- id: status_long_toss_id_value
  type: b32
  enum: status_long_toss_id_enum
enums:
  status_long_toss_id_enum:
    0: status_long_toss_none
    1: status_long_toss_long_toss
    2: status_long_toss_pierce
