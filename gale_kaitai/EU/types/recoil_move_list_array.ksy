doc: Represents an array RECOIL_MOVE_LIST defined within pmdsky.
meta:
  id: recoil_move_list_array
  endian: le
  bit-endian: le
  imports:
  - move_id_16
seq:
- id: entries
  type: recoil_move_list_array_dim_0
types:
  recoil_move_list_array_dim_0:
    seq:
    - id: entries
      type: move_id_16
      repeat: expr
      repeat-expr: 11
