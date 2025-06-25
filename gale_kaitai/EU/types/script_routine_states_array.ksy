doc: Represents an array script_routine_states defined within pmdsky.
meta:
  id: script_routine_states_array
  endian: le
  bit-endian: le
  imports:
  - script_routine_state
seq:
- id: entries
  type: script_routine_states_array_dim_0
types:
  script_routine_states_array_dim_0:
    seq:
    - id: entries
      type: script_routine_state
      repeat: expr
      repeat-expr: 2
