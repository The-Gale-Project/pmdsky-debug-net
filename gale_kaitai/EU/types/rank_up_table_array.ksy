doc: Represents an array RANK_UP_TABLE defined within pmdsky.
meta:
  id: rank_up_table_array
  endian: le
  bit-endian: le
  imports:
  - rankup_table_entry
seq:
- id: entries
  type: rank_up_table_array_dim_0
types:
  rank_up_table_array_dim_0:
    seq:
    - id: entries
      type: rankup_table_entry
      repeat: expr
      repeat-expr: 13
