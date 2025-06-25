doc: Represents an array scroll_box_unk_struct_arr defined within pmdsky.
meta:
  id: scroll_box_unk_struct_arr_array
  endian: le
  bit-endian: le
  imports:
  - unk_scroll_box_struct
seq:
- id: entries
  type: scroll_box_unk_struct_arr_array_dim_0
types:
  scroll_box_unk_struct_arr_array_dim_0:
    seq:
    - id: entries
      type: unk_scroll_box_struct
      repeat: expr
      repeat-expr: 4
