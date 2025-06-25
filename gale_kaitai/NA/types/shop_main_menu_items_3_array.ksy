doc: Represents an array SHOP_MAIN_MENU_ITEMS_3 defined within pmdsky.
meta:
  id: shop_main_menu_items_3_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: shop_main_menu_items_3_array_dim_0
types:
  shop_main_menu_items_3_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 6
