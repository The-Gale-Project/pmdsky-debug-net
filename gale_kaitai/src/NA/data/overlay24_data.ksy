meta:
  id: overlay24_data
  endian: le
instances:
  overlay24_unknown_struct_na_238c508:
    pos: 0x23c8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc
  overlay24_unknown_struct_na_238c514:
    pos: 0x23d4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc
  daycare_menu_items_confirm:
    pos: 0x23e0
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  daycare_main_menu_items:
    pos: 0x23f8
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  overlay24_unknown_string_ids:
    pos: 0x2418
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x38
  daycare_window_params_1:
    pos: 0x2450
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  daycare_window_params_2:
    pos: 0x2460
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  daycare_window_params_3:
    pos: 0x2470
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  daycare_window_params_4:
    pos: 0x2480
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  daycare_window_params_5:
    pos: 0x2490
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  overlay24_reserved_space:
    pos: 0x24a0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x20
  overlay24_unknown_pointer_na_238c600:
    pos: 0x24c0
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
