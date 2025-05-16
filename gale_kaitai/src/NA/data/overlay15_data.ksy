meta:
  id: overlay15_data
  endian: le
instances:
  bank_main_menu_items:
    pos: 0xf14
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  bank_window_params_1:
    pos: 0xf3c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bank_window_params_2:
    pos: 0xf4c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bank_window_params_3:
    pos: 0xf5c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bank_window_params_4:
    pos: 0xf6c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bank_window_params_5:
    pos: 0xf7c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  overlay15_reserved_space:
    pos: 0x1024
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x1c
  overlay15_unknown_pointer_na_238b180:
    pos: 0x1040
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
