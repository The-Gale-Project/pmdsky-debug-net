doc: Represents an array IMPRISON_TURN_RANGE defined within pmdsky.
meta:
  id: imprison_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: imprison_turn_range_array_dim_0
types:
  imprison_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
