meta:
  id: overlay20_data
  endian: le
instances:
  overlay20_unknown_pointer_na_238cf7c:
    pos: 0x2e3c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x8
  recycle_menu_items_confirm_1:
    pos: 0x2e44
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  recycle_menu_items_confirm_2:
    pos: 0x2e5c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  recycle_submenu_items_1:
    pos: 0x2e74
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  recycle_submenu_items_2:
    pos: 0x2e8c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  recycle_main_menu_items_1:
    pos: 0x2eac
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  overlay20_unknown_table_na_238d014:
    pos: 0x2ed4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x14
  recycle_window_params_1:
    pos: 0x2ee8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_2:
    pos: 0x2ef8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_3:
    pos: 0x2f08
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_4:
    pos: 0x2f18
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_5:
    pos: 0x2f28
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_6:
    pos: 0x2f38
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_main_menu_items_2:
    pos: 0x2f48
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  recycle_window_params_7:
    pos: 0x2f68
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_8:
    pos: 0x2f78
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_9:
    pos: 0x2f88
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_10:
    pos: 0x2f98
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_window_params_11:
    pos: 0x2fa8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  recycle_main_menu_items_3:
    pos: 0x2fb8
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  overlay20_reserved_space:
    pos: 0x2fd0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
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
