doc: Represents an array damage_calc_diag_move_indiv_type_matchups defined 
  within pmdsky.
meta:
  id: damage_calc_diag_move_indiv_type_matchups_array
  endian: le
  bit-endian: le
  imports:
  - type_matchup_8
seq:
- id: entries
  type: damage_calc_diag_move_indiv_type_matchups_array_dim_0
types:
  damage_calc_diag_move_indiv_type_matchups_array_dim_0:
    seq:
    - id: entries
      type: type_matchup_8
      repeat: expr
      repeat-expr: 2
