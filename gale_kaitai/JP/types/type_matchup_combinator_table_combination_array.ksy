doc: Represents an array type_matchup_combinator_table_combination defined 
  within pmdsky.
meta:
  id: type_matchup_combinator_table_combination_array
  endian: le
  bit-endian: le
  imports:
  - type_matchup
seq:
- id: entries
  type: type_matchup_combinator_table_combination_array_dim_1
types:
  type_matchup_combinator_table_combination_array_dim_0:
    seq:
    - id: entries
      type: type_matchup
      repeat: expr
      repeat-expr: 4
  type_matchup_combinator_table_combination_array_dim_1:
    seq:
    - id: entries
      type: type_matchup_combinator_table_combination_array_dim_0
      repeat: expr
      repeat-expr: 4
