doc: Represents an array DUNGEON_MENU_SWITCH_STR1 defined within pmdsky.
meta:
  id: dungeon_menu_switch_str1_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_menu_switch_str1_array_dim_0
types:
  dungeon_menu_switch_str1_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 12
