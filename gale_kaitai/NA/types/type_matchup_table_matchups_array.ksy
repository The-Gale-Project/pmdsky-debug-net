doc: Represents an array type_matchup_table_matchups defined within pmdsky.
meta:
  id: type_matchup_table_matchups_array
  endian: le
  bit-endian: le
  imports:
  - type_matchup_16
seq:
- id: entries
  type: type_matchup_table_matchups_array_dim_1
types:
  type_matchup_table_matchups_array_dim_0:
    seq:
    - id: entries
      type: type_matchup_16
      repeat: expr
      repeat-expr: 18
  type_matchup_table_matchups_array_dim_1:
    seq:
    - id: entries
      type: type_matchup_table_matchups_array_dim_0
      repeat: expr
      repeat-expr: 18
