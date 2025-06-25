doc: Represents an array SURE_SHOT_TURN_RANGE defined within pmdsky.
meta:
  id: sure_shot_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: sure_shot_turn_range_array_dim_0
types:
  sure_shot_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
