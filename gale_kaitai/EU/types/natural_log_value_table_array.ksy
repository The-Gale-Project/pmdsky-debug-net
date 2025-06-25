doc: Represents an array NATURAL_LOG_VALUE_TABLE defined within pmdsky.
meta:
  id: natural_log_value_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: natural_log_value_table_array_dim_0
types:
  natural_log_value_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2048
