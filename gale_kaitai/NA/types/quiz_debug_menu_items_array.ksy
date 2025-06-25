doc: Represents an array QUIZ_DEBUG_MENU_ITEMS defined within pmdsky.
meta:
  id: quiz_debug_menu_items_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: quiz_debug_menu_items_array_dim_0
types:
  quiz_debug_menu_items_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 9
