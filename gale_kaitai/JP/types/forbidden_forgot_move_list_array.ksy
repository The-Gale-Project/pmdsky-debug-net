doc: Represents an array FORBIDDEN_FORGOT_MOVE_LIST defined within pmdsky.
meta:
  id: forbidden_forgot_move_list_array
  endian: le
  bit-endian: le
  imports:
  - forbidden_forgot_move_entry
seq:
- id: entries
  type: forbidden_forgot_move_list_array_dim_0
types:
  forbidden_forgot_move_list_array_dim_0:
    seq:
    - id: entries
      type: forbidden_forgot_move_entry
      repeat: expr
      repeat-expr: 3
