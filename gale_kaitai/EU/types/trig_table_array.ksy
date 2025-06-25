doc: Represents an array TRIG_TABLE defined within pmdsky.
meta:
  id: trig_table_array
  endian: le
  bit-endian: le
  imports:
  - trig_values
seq:
- id: entries
  type: trig_table_array_dim_0
types:
  trig_table_array_dim_0:
    seq:
    - id: entries
      type: trig_values
      repeat: expr
      repeat-expr: 4096
