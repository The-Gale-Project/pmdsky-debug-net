doc: Represents an array input_lock_box_string_buffer defined within pmdsky.
meta:
  id: input_lock_box_string_buffer_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: input_lock_box_string_buffer_array_dim_0
types:
  input_lock_box_string_buffer_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 256
