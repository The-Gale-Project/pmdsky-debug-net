meta:
  id: overlay18_data
  endian: le
instances:
  link_shop_window_params_1:
    pos: 0x3130
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_2:
    pos: 0x3140
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_3:
    pos: 0x3150
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_4:
    pos: 0x3160
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_5:
    pos: 0x3170
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_6:
    pos: 0x3180
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_7:
    pos: 0x3190
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_8:
    pos: 0x31a0
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_9:
    pos: 0x31b0
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_10:
    pos: 0x31c0
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_11:
    pos: 0x31d0
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_menu_items_confirm:
    pos: 0x31e0
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  link_shop_submenu_items_1:
    pos: 0x31f8
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  link_shop_submenu_items_2:
    pos: 0x3218
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  link_shop_main_menu_items:
    pos: 0x3238
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  link_shop_submenu_items_3:
    pos: 0x3258
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  link_shop_submenu_items_4:
    pos: 0x3280
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 6
  link_shop_submenu_items_5:
    pos: 0x32b0
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 9
  link_shop_submenu_items_6:
    pos: 0x32f8
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 9
  link_shop_submenu_items_7:
    pos: 0x3340
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 9
  overlay18_function_pointer_table:
    pos: 0x3388
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: u4
    repeat: expr
    repeat-expr: 76
  overlay18_reserved_space:
    pos: 0x34dc
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay18_unknown_pointer_na_238d620:
    pos: 0x34e0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay18_unknown_pointer_na_238d624:
    pos: 0x34e4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay18_unknown_pointer_na_238d628:
    pos: 0x34e8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
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
