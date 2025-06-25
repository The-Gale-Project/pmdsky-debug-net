doc: Represents an array debug_menu_item_string defined within pmdsky.
meta:
  id: debug_menu_item_string_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: debug_menu_item_string_array_dim_0
types:
  debug_menu_item_string_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 256
