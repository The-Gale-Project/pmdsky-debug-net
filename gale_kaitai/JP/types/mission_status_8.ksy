doc: Holds bitsized data for the parent enum mission_status.
meta:
  id: mission_status_8
  endian: le
  bit-endian: le
seq:
- id: mission_status_8_value
  type: b8
  enum: mission_status_8_enum
enums:
  mission_status_8_enum:
    0: mission_status_invalid
    1: mission_status_unk_1
    2: mission_status_unk_2
    3: mission_status_unk_3
    4: mission_status_suspended
    5: mission_status_accepted
    6: mission_status_done
    7: mission_status_unk_7
    8: mission_status_unk_8
