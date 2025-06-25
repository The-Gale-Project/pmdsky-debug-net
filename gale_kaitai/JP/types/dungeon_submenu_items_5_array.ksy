doc: Represents an array DUNGEON_SUBMENU_ITEMS_5 defined within pmdsky.
meta:
  id: dungeon_submenu_items_5_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: dungeon_submenu_items_5_array_dim_0
types:
  dungeon_submenu_items_5_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 3
