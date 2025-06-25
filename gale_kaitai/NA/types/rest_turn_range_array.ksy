doc: Represents an array REST_TURN_RANGE defined within pmdsky.
meta:
  id: rest_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: rest_turn_range_array_dim_0
types:
  rest_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
