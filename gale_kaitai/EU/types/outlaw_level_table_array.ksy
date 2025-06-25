doc: Represents an array OUTLAW_LEVEL_TABLE defined within pmdsky.
meta:
  id: outlaw_level_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: outlaw_level_table_array_dim_0
types:
  outlaw_level_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 16
