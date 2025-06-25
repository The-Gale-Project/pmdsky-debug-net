doc: Represents an array C_ROUTINE_NAMES defined within pmdsky.
meta:
  id: c_routine_names_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: c_routine_names_array_dim_0
types:
  c_routine_names_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 0
