meta:
  id: overlay22_data
  endian: le
instances:
  shop_window_params_1:
    pos: 0x46dc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_2:
    pos: 0x46fc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_menu_items_confirm:
    pos: 0x4728
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  shop_main_menu_items_1:
    pos: 0x4740
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  shop_main_menu_items_2:
    pos: 0x4760
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  shop_main_menu_items_3:
    pos: 0x4780
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 6
  shop_window_params_6:
    pos: 0x4840
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_7:
    pos: 0x4850
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_8:
    pos: 0x4860
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_9:
    pos: 0x4870
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_10:
    pos: 0x4880
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
