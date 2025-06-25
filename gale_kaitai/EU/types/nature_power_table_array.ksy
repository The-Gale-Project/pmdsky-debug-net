doc: Represents an array NATURE_POWER_TABLE defined within pmdsky.
meta:
  id: nature_power_table_array
  endian: le
  bit-endian: le
  imports:
  - wildcard_move_desc
seq:
- id: entries
  type: nature_power_table_array_dim_0
types:
  nature_power_table_array_dim_0:
    seq:
    - id: entries
      type: wildcard_move_desc
      repeat: expr
      repeat-expr: 15
