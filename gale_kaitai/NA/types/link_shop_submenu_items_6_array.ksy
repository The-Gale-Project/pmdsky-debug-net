doc: Represents an array LINK_SHOP_SUBMENU_ITEMS_6 defined within pmdsky.
meta:
  id: link_shop_submenu_items_6_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: link_shop_submenu_items_6_array_dim_0
types:
  link_shop_submenu_items_6_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 9
