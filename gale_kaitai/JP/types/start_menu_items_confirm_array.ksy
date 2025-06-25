doc: Represents an array START_MENU_ITEMS_CONFIRM defined within pmdsky.
meta:
  id: start_menu_items_confirm_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: start_menu_items_confirm_array_dim_0
types:
  start_menu_items_confirm_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 3
