doc: Represents an array BAR_SUBMENU_ITEMS_1 defined within pmdsky.
meta:
  id: bar_submenu_items_1_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: bar_submenu_items_1_array_dim_0
types:
  bar_submenu_items_1_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 4
