meta:
  id: overlay34_data
  endian: le
instances:
  start_menu_items_confirm:
    pos: 0xd4c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  dungeon_debug_menu_items:
    pos: 0xd74
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
types:
  simple_menu_id_item:
  - id: string_id
    type: u2
  - id: _padding
    type: u2
  - id: result_value
    type: s4
enums: {}
