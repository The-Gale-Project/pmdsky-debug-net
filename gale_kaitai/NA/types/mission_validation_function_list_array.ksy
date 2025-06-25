doc: Represents an array MISSION_VALIDATION_FUNCTION_LIST defined within pmdsky.
meta:
  id: mission_validation_function_list_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: mission_validation_function_list_array_dim_0
types:
  mission_validation_function_list_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 8
