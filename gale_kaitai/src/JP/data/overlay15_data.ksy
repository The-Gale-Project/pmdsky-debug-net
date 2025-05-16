meta:
  id: overlay15_data
  endian: le
instances:
  bank_main_menu_items:
    pos: 0xf2c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  bank_window_params_2:
    pos: 0xf64
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bank_window_params_3:
    pos: 0xf74
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bank_window_params_4:
    pos: 0xf84
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
