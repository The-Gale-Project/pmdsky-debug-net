meta:
  id: overlay18_data
  endian: le
instances:
  link_shop_window_params_1:
    pos: 0x313c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_2:
    pos: 0x314c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_3:
    pos: 0x315c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_4:
    pos: 0x316c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_5:
    pos: 0x317c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_6:
    pos: 0x318c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_7:
    pos: 0x319c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_8:
    pos: 0x31ac
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_9:
    pos: 0x31bc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_10:
    pos: 0x31cc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_window_params_11:
    pos: 0x31dc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  link_shop_menu_items_confirm:
    pos: 0x31ec
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  link_shop_submenu_items_1:
    pos: 0x3204
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  link_shop_submenu_items_2:
    pos: 0x3224
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  link_shop_main_menu_items:
    pos: 0x3244
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  link_shop_submenu_items_3:
    pos: 0x3264
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  link_shop_submenu_items_4:
    pos: 0x328c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 6
  link_shop_submenu_items_5:
    pos: 0x32bc
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 9
  link_shop_submenu_items_6:
    pos: 0x3304
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 9
  link_shop_submenu_items_7:
    pos: 0x334c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 9
  overlay18_function_pointer_table:
    pos: 0x3394
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: u4
    repeat: expr
    repeat-expr: 76
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
