doc: Represents an array dialogue_box_string_data defined within pmdsky.
meta:
  id: dialogue_box_string_data_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dialogue_box_string_data_array_dim_0
types:
  dialogue_box_string_data_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 1024
