doc: Represents an array SMD_EVENTS_FUN_TABLE defined within pmdsky.
meta:
  id: smd_events_fun_table_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: smd_events_fun_table_array_dim_0
types:
  smd_events_fun_table_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 127
