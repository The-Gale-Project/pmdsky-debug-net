doc: Represents an array STORAGE_MAIN_MENU_ITEMS_2 defined within pmdsky.
meta:
  id: storage_main_menu_items_2_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: storage_main_menu_items_2_array_dim_0
types:
  storage_main_menu_items_2_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 4
