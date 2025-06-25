doc: Represents an array BANK_MAIN_MENU_ITEMS defined within pmdsky.
meta:
  id: bank_main_menu_items_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: bank_main_menu_items_array_dim_0
types:
  bank_main_menu_items_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 5
