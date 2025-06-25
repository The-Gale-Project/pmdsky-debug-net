doc: Represents an array DUNGEON_DEBUG_MENU_ITEMS defined within pmdsky.
meta:
  id: dungeon_debug_menu_items_array
  endian: le
  bit-endian: le
  imports:
  - simple_menu_id_item
seq:
- id: entries
  type: dungeon_debug_menu_items_array_dim_0
types:
  dungeon_debug_menu_items_array_dim_0:
    seq:
    - id: entries
      type: simple_menu_id_item
      repeat: expr
      repeat-expr: 5
