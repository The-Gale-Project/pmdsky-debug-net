doc: Represents an array SETANIMATION_TABLE defined within pmdsky.
meta:
  id: setanimation_table_array
  endian: le
  bit-endian: le
  imports:
  - animation_data
seq:
- id: entries
  type: setanimation_table_array_dim_0
types:
  setanimation_table_array_dim_0:
    seq:
    - id: entries
      type: animation_data
      repeat: expr
      repeat-expr: 84
