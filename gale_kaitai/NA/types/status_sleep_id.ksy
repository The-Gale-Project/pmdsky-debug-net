doc: Holds the data for the enum status_sleep_id.
meta:
  id: status_sleep_id
  endian: le
  bit-endian: le
seq:
- id: status_sleep_id_value
  type: b32
  enum: status_sleep_id_enum
enums:
  status_sleep_id_enum:
    0: status_sleep_none
    1: status_sleep_sleep
    2: status_sleep_sleepless
    3: status_sleep_nightmare
    4: status_sleep_yawning
    5: status_sleep_napping
