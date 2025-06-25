doc: Holds bitsized data for the parent enum status_frozen_id.
meta:
  id: status_frozen_id_8
  endian: le
  bit-endian: le
seq:
- id: status_frozen_id_8_value
  type: b8
  enum: status_frozen_id_8_enum
enums:
  status_frozen_id_8_enum:
    0: status_frozen_none
    1: status_frozen_frozen
    2: status_frozen_shadow_hold
    3: status_frozen_wrap
    4: status_frozen_wrapped
    5: status_frozen_ingrain
    6: status_frozen_petrified
    7: status_frozen_constriction
