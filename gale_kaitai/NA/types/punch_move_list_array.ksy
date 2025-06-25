doc: Represents an array PUNCH_MOVE_LIST defined within pmdsky.
meta:
  id: punch_move_list_array
  endian: le
  bit-endian: le
  imports:
  - move_id_16
seq:
- id: entries
  type: punch_move_list_array_dim_0
types:
  punch_move_list_array_dim_0:
    seq:
    - id: entries
      type: move_id_16
      repeat: expr
      repeat-expr: 16
