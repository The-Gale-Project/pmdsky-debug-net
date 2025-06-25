doc: Holds bitsized data for the parent enum script_routine_kind.
meta:
  id: script_routine_kind_16
  endian: le
  bit-endian: le
seq:
- id: script_routine_kind_16_value
  type: b16
  enum: script_routine_kind_16_enum
enums:
  script_routine_kind_16_enum:
    1: routine_main
    2: routine_0x2
    3: routine_actor
    4: routine_object
    5: routine_performer
    6: routine_0x6
    7: routine_0x7
    8: routine_0x8
    9: routine_unionall
