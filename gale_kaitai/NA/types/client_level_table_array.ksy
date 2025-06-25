doc: Represents an array CLIENT_LEVEL_TABLE defined within pmdsky.
meta:
  id: client_level_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: client_level_table_array_dim_0
types:
  client_level_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 16
