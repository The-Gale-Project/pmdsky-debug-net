doc: Represents an array common_routine_table_routines defined within pmdsky.
meta:
  id: common_routine_table_routines_array
  endian: le
  bit-endian: le
  imports:
  - common_routine
seq:
- id: entries
  type: common_routine_table_routines_array_dim_0
types:
  common_routine_table_routines_array_dim_0:
    seq:
    - id: entries
      type: common_routine
      repeat: expr
      repeat-expr: 701
