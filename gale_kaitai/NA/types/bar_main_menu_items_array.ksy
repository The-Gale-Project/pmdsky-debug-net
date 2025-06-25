doc: Represents an array BAR_MAIN_MENU_ITEMS defined within pmdsky.
meta:
  id: bar_main_menu_items_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: bar_main_menu_items_array_dim_0
types:
  bar_main_menu_items_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 4
