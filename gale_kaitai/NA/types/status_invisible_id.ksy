doc: Holds the data for the enum status_invisible_id.
meta:
  id: status_invisible_id
  endian: le
  bit-endian: le
seq:
- id: status_invisible_id_value
  type: b32
  enum: status_invisible_id_enum
enums:
  status_invisible_id_enum:
    0: status_invisible_none
    1: status_invisible_invisible
    2: status_invisible_transformed
    3: status_invisible_mobile
    4: status_invisible_slip
