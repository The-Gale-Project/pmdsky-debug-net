doc: Represents an array scroll_box_strings2 defined within pmdsky.
meta:
  id: scroll_box_strings2_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: scroll_box_strings2_array_dim_0
types:
  scroll_box_strings2_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 8
