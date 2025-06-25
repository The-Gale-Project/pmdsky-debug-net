doc: Represents an array SMOKESCREEN_TURN_RANGE defined within pmdsky.
meta:
  id: smokescreen_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: smokescreen_turn_range_array_dim_0
types:
  smokescreen_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
