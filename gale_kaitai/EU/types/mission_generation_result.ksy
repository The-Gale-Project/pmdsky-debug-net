doc: Holds the data for the enum mission_generation_result.
meta:
  id: mission_generation_result
  endian: le
  bit-endian: le
seq:
- id: mission_generation_result_value
  type: b32
  enum: mission_generation_result_enum
enums:
  mission_generation_result_enum:
    0: mission_generation_success
    1: mission_generation_failure
    2: mission_generation_global_failure
