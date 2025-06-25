doc: Represents an array HIDDEN_POWER_BASE_POWER_TABLE defined within pmdsky.
meta:
  id: hidden_power_base_power_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: hidden_power_base_power_table_array_dim_0
types:
  hidden_power_base_power_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 10
