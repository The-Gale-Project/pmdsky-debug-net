meta:
  id: overlay27_data
  endian: le
instances:
  overlay27_unknown_value_na_238c948:
    pos: 0x2808
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay27_unknown_value_na_238c94c:
    pos: 0x280c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay27_unknown_struct_na_238c950:
    pos: 0x2810
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc
  discard_items_menu_items_confirm:
    pos: 0x281c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  discard_items_submenu_items_1:
    pos: 0x2834
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  discard_items_submenu_items_2:
    pos: 0x2854
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  discard_items_main_menu_items:
    pos: 0x2874
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  overlay27_unknown_string_ids:
    pos: 0x289c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x30
  discard_window_params_1:
    pos: 0x28cc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  discard_window_params_2:
    pos: 0x28dc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  discard_window_params_3:
    pos: 0x28ec
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  discard_window_params_4:
    pos: 0x28fc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  discard_window_params_5:
    pos: 0x290c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  discard_window_params_6:
    pos: 0x291c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  discard_window_params_7:
    pos: 0x292c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  discard_window_params_8:
    pos: 0x293c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  overlay27_reserved_space:
    pos: 0x2d30
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  overlay27_unknown_pointer_na_238ce80:
    pos: 0x2d40
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay27_unknown_pointer_na_238ce84:
    pos: 0x2d44
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
