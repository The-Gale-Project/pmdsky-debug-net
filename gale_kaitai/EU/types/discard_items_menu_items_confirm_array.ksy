doc: Represents an array DISCARD_ITEMS_MENU_ITEMS_CONFIRM defined within pmdsky.
meta:
  id: discard_items_menu_items_confirm_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: discard_items_menu_items_confirm_array_dim_0
types:
  discard_items_menu_items_confirm_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 3
