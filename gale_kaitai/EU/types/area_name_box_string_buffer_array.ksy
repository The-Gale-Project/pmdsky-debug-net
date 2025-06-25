doc: Represents an array area_name_box_string_buffer defined within pmdsky.
meta:
  id: area_name_box_string_buffer_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: area_name_box_string_buffer_array_dim_0
types:
  area_name_box_string_buffer_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 256
