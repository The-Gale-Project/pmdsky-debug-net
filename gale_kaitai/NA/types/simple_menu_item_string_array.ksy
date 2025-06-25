doc: Represents an array simple_menu_item_string defined within pmdsky.
meta:
  id: simple_menu_item_string_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: simple_menu_item_string_array_dim_0
types:
  simple_menu_item_string_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 256
