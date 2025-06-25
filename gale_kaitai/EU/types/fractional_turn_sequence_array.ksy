doc: Represents an array FRACTIONAL_TURN_SEQUENCE defined within pmdsky.
meta:
  id: fractional_turn_sequence_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: fractional_turn_sequence_array_dim_0
types:
  fractional_turn_sequence_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 125
