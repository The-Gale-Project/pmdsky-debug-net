doc: Represents an array QUIZ_MENU_ITEMS_1 defined within pmdsky.
meta:
  id: quiz_menu_items_1_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: quiz_menu_items_1_array_dim_0
types:
  quiz_menu_items_1_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 3
