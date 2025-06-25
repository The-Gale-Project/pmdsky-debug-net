doc: Represents an array RECYCLE_SUBMENU_ITEMS_2 defined within pmdsky.
meta:
  id: recycle_submenu_items_2_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: recycle_submenu_items_2_array_dim_0
types:
  recycle_submenu_items_2_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 4
