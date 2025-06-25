doc: Represents an array TACTICS_UNLOCK_LEVEL_TABLE defined within pmdsky.
meta:
  id: tactics_unlock_level_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: tactics_unlock_level_table_array_dim_0
types:
  tactics_unlock_level_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 12
