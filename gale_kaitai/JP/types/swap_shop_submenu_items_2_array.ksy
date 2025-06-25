doc: Represents an array SWAP_SHOP_SUBMENU_ITEMS_2 defined within pmdsky.
meta:
  id: swap_shop_submenu_items_2_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: swap_shop_submenu_items_2_array_dim_0
types:
  swap_shop_submenu_items_2_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 4
