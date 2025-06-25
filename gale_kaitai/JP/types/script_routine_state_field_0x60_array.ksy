doc: Represents an array script_routine_state_field_0x60 defined within pmdsky.
meta:
  id: script_routine_state_field_0x60_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: script_routine_state_field_0x60_array_dim_0
types:
  script_routine_state_field_0x60_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 4
