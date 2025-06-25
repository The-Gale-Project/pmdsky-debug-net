doc: Represents an array scroll_box_preprocessor_args1 defined within pmdsky.
meta:
  id: scroll_box_preprocessor_args1_array
  endian: le
  bit-endian: le
  imports:
  - preprocessor_args
seq:
- id: entries
  type: scroll_box_preprocessor_args1_array_dim_0
types:
  scroll_box_preprocessor_args1_array_dim_0:
    seq:
    - id: entries
      type: preprocessor_args
      repeat: expr
      repeat-expr: 4
