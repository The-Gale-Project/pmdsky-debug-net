meta:
  id: overlay1_data
  endian: le
instances:
  main_menu_window_params_1:
    pos: 0x120d8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_2:
    pos: 0x120e8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_3:
    pos: 0x120f8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_4:
    pos: 0x12108
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  continue_choice:
    pos: 0x12128
    size: 0x20
  submenu:
    pos: 0x12148
    size: 0x48
  main_menu:
    pos: 0x12190
    size: 0xa0
  main_menu_window_params_5:
    pos: 0x122d4
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_6:
    pos: 0x122e4
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_7:
    pos: 0x122f4
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_items_confirm:
    pos: 0x12304
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  main_menu_window_params_8:
    pos: 0x12388
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_9:
    pos: 0x123a8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_debug_menu_items_1:
    pos: 0x123c8
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 12
  main_menu_window_params_10:
    pos: 0x12428
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_debug_menu_items_2:
    pos: 0x12448
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 7
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
