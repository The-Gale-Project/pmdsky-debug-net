doc: Represents an array debug_menu_string_buffer1 defined within pmdsky.
meta:
  id: debug_menu_string_buffer1_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: debug_menu_string_buffer1_array_dim_0
types:
  debug_menu_string_buffer1_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 256
