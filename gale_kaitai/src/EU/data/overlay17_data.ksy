meta:
  id: overlay17_data
  endian: le
instances:
  assembly_window_params_1:
    pos: 0x19f4
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  assembly_window_params_2:
    pos: 0x1a04
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  assembly_window_params_3:
    pos: 0x1a14
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  assembly_window_params_4:
    pos: 0x1a24
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  assembly_window_params_5:
    pos: 0x1a34
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  assembly_menu_items_confirm:
    pos: 0x1a44
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  assembly_main_menu_items_1:
    pos: 0x1a5c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  assembly_main_menu_items_2:
    pos: 0x1a74
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  assembly_submenu_items_1:
    pos: 0x1a94
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  assembly_submenu_items_2:
    pos: 0x1abc
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 6
  assembly_submenu_items_3:
    pos: 0x1aec
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 6
  assembly_submenu_items_4:
    pos: 0x1b1c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 7
  assembly_submenu_items_5:
    pos: 0x1b54
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 7
  assembly_submenu_items_6:
    pos: 0x1b8c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 7
  assembly_submenu_items_7:
    pos: 0x1bc4
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 8
  overlay17_function_pointer_table:
    pos: 0x1c04
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: u4
    repeat: expr
    repeat-expr: 42
types:
  window_params:
  - id: update
    type: update_window_fn_t
  - id: x_offset
    type: u1
  - id: y_offset
    type: u1
  - id: width
    type: u1
  - id: height
    type: u1
  - id: screen
    type: screen_8
  - id: box_type
    type: box_type_8
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  simple_menu_id_item:
  - id: string_id
    type: u2
  - id: _padding
    type: u2
  - id: result_value
    type: s4
enums: {}
