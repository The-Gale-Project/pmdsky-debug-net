doc: Represents an array scroll_box_string_ids2 defined within pmdsky.
meta:
  id: scroll_box_string_ids2_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: scroll_box_string_ids2_array_dim_0
types:
  scroll_box_string_ids2_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 4
