doc: Represents an array SPEED_BOOST_TURN_RANGE defined within pmdsky.
meta:
  id: speed_boost_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: speed_boost_turn_range_array_dim_0
types:
  speed_boost_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
