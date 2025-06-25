doc: Holds the data for the enum status_blinker_id.
meta:
  id: status_blinker_id
  endian: le
  bit-endian: le
seq:
- id: status_blinker_id_value
  type: b32
  enum: status_blinker_id_enum
enums:
  status_blinker_id_enum:
    0: status_blinker_none
    1: status_blinker_blinker
    2: status_blinker_cross_eyed
    3: status_blinker_eyedrops
    4: status_blinker_dropeye
