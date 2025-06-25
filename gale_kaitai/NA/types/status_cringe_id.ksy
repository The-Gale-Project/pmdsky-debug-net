doc: Holds the data for the enum status_cringe_id.
meta:
  id: status_cringe_id
  endian: le
  bit-endian: le
seq:
- id: status_cringe_id_value
  type: b32
  enum: status_cringe_id_enum
enums:
  status_cringe_id_enum:
    0: status_cringe_none
    1: status_cringe_cringe
    2: status_cringe_confused
    3: status_cringe_paused
    4: status_cringe_cowering
    5: status_cringe_taunted
    6: status_cringe_encore
    7: status_cringe_infatuated
