doc: Represents an array SPORT_CONDITION_TURN_RANGE defined within pmdsky.
meta:
  id: sport_condition_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: sport_condition_turn_range_array_dim_0
types:
  sport_condition_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
