doc: Represents an array NIGHTMARE_TURN_RANGE defined within pmdsky.
meta:
  id: nightmare_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: nightmare_turn_range_array_dim_0
types:
  nightmare_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
