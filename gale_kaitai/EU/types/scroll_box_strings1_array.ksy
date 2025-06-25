doc: Represents an array scroll_box_strings1 defined within pmdsky.
meta:
  id: scroll_box_strings1_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: scroll_box_strings1_array_dim_0
types:
  scroll_box_strings1_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 8
