doc: Represents an array TWO_TURN_STATUSES defined within pmdsky.
meta:
  id: two_turn_statuses_array
  endian: le
  bit-endian: le
  imports:
  - status_two_turn_id_8
seq:
- id: entries
  type: two_turn_statuses_array_dim_0
types:
  two_turn_statuses_array_dim_0:
    seq:
    - id: entries
      type: status_two_turn_id_8
      repeat: expr
      repeat-expr: 11
