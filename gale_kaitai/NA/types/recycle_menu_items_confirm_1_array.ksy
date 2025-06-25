doc: Represents an array RECYCLE_MENU_ITEMS_CONFIRM_1 defined within pmdsky.
meta:
  id: recycle_menu_items_confirm_1_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: recycle_menu_items_confirm_1_array_dim_0
types:
  recycle_menu_items_confirm_1_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 3
