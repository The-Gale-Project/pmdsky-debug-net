doc: Represents an array scroll_box_string_buffer1 defined within pmdsky.
meta:
  id: scroll_box_string_buffer1_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: scroll_box_string_buffer1_array_dim_0
types:
  scroll_box_string_buffer1_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 1024
