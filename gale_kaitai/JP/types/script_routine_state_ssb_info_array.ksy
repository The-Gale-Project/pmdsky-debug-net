doc: Represents an array script_routine_state_ssb_info defined within pmdsky.
meta:
  id: script_routine_state_ssb_info_array
  endian: le
  bit-endian: le
  imports:
  - ssb_runtime_info
seq:
- id: entries
  type: script_routine_state_ssb_info_array_dim_0
types:
  script_routine_state_ssb_info_array_dim_0:
    seq:
    - id: entries
      type: ssb_runtime_info
      repeat: expr
      repeat-expr: 2
