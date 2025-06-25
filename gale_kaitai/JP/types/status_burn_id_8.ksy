doc: Holds bitsized data for the parent enum status_burn_id.
meta:
  id: status_burn_id_8
  endian: le
  bit-endian: le
seq:
- id: status_burn_id_8_value
  type: b8
  enum: status_burn_id_8_enum
enums:
  status_burn_id_8_enum:
    0: status_burn_none
    1: status_burn_burn
    2: status_burn_poisoned
    3: status_burn_badly_poisoned
    4: status_burn_paralysis
