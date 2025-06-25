doc: Represents an array SLEEP_TURN_RANGE defined within pmdsky.
meta:
  id: sleep_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: sleep_turn_range_array_dim_0
types:
  sleep_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
