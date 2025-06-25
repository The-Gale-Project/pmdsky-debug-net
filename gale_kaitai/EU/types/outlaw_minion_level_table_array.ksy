doc: Represents an array OUTLAW_MINION_LEVEL_TABLE defined within pmdsky.
meta:
  id: outlaw_minion_level_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: outlaw_minion_level_table_array_dim_0
types:
  outlaw_minion_level_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 16
