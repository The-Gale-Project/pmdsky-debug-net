meta:
  id: overlay21_data
  endian: le
instances:
  swap_shop_window_params_1:
    pos: 0x28e8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  swap_shop_menu_items_confirm:
    pos: 0x28f8
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  swap_shop_submenu_items_1:
    pos: 0x2910
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  swap_shop_submenu_items_2:
    pos: 0x2928
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  swap_shop_main_menu_items_1:
    pos: 0x2948
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  swap_shop_main_menu_items_2:
    pos: 0x2968
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  swap_shop_submenu_items_3:
    pos: 0x2990
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 6
  swap_shop_window_params_5:
    pos: 0x2a28
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  swap_shop_window_params_6:
    pos: 0x2a38
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  swap_shop_window_params_7:
    pos: 0x2a48
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  swap_shop_window_params_8:
    pos: 0x2a58
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  swap_shop_window_params_9:
    pos: 0x2a68
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
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
