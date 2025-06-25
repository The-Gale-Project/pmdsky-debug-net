doc: Represents an array YAWN_TURN_RANGE defined within pmdsky.
meta:
  id: yawn_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: yawn_turn_range_array_dim_0
types:
  yawn_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
