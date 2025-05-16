meta:
  id: overlay20_data
  endian: le
instances:
  recycle_menu_items_confirm_1:
    pos: 0x2e40
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  recycle_menu_items_confirm_2:
    pos: 0x2e58
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  recycle_submenu_items_1:
    pos: 0x2e70
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  recycle_submenu_items_2:
    pos: 0x2e88
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  recycle_main_menu_items_1:
    pos: 0x2ea8
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  recycle_window_params_1:
    pos: 0x2ee4
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_2:
    pos: 0x2ef4
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_3:
    pos: 0x2f04
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_4:
    pos: 0x2f14
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_5:
    pos: 0x2f24
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_6:
    pos: 0x2f34
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_main_menu_items_2:
    pos: 0x2f44
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  recycle_window_params_7:
    pos: 0x2f64
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_8:
    pos: 0x2f74
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_9:
    pos: 0x2f84
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_10:
    pos: 0x2f94
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_11:
    pos: 0x2fa4
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_main_menu_items_3:
    pos: 0x2fb4
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  overlay20_unknown_pointer_na_238d120:
    pos: 0x2fe0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay20_unknown_pointer_na_238d124:
    pos: 0x2fe4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay20_unknown_pointer_na_238d128:
    pos: 0x2fe8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay20_unknown_pointer_na_238d12c:
    pos: 0x2fec
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
types:
  simple_menu_id_item:
  - id: string_id
    type: u2
  - id: _padding
    type: u2
  - id: result_value
    type: s4
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
enums: {}
