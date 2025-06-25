doc: Holds the data for the enum fade_status.
meta:
  id: fade_status
  endian: le
  bit-endian: le
seq:
- id: fade_status_value
  type: b32
  enum: fade_status_enum
enums:
  fade_status_enum:
    0: fade_none
    1: fade_complete
    2: fade_in
    3: fade_out
