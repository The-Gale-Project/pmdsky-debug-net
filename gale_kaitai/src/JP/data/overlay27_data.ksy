meta:
  id: overlay27_data
  endian: le
instances:
  discard_items_menu_items_confirm:
    pos: 0x284c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  discard_items_submenu_items_1:
    pos: 0x2864
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  discard_items_submenu_items_2:
    pos: 0x2884
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  discard_items_main_menu_items:
    pos: 0x28a4
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  discard_window_params_5:
    pos: 0x293c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  discard_window_params_6:
    pos: 0x294c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  discard_window_params_7:
    pos: 0x295c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
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
