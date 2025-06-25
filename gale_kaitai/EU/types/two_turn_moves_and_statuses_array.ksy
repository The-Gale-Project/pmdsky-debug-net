doc: Represents an array TWO_TURN_MOVES_AND_STATUSES defined within pmdsky.
meta:
  id: two_turn_moves_and_statuses_array
  endian: le
  bit-endian: le
  imports:
  - two_turn_move_and_status
seq:
- id: entries
  type: two_turn_moves_and_statuses_array_dim_0
types:
  two_turn_moves_and_statuses_array_dim_0:
    seq:
    - id: entries
      type: two_turn_move_and_status
      repeat: expr
      repeat-expr: 22
