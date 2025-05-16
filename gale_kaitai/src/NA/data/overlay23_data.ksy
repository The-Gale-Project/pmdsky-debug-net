meta:
  id: overlay23_data
  endian: le
instances:
  overlay23_unknown_value_na_238d2e8:
    pos: 0x31a8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay23_unknown_value_na_238d2ec:
    pos: 0x31ac
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay23_unknown_struct_na_238d2f0:
    pos: 0x31b0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc
  storage_menu_items_confirm:
    pos: 0x31bc
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  storage_main_menu_items_1:
    pos: 0x31d4
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  storage_main_menu_items_2:
    pos: 0x31f4
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  storage_main_menu_items_3:
    pos: 0x3214
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  storage_main_menu_items_4:
    pos: 0x3234
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  overlay23_unknown_string_ids:
    pos: 0x325c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x2c
  storage_window_params_1:
    pos: 0x3288
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_2:
    pos: 0x3298
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_3:
    pos: 0x32a8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_4:
    pos: 0x32b8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_5:
    pos: 0x32c8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_6:
    pos: 0x32d8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_7:
    pos: 0x32e8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_8:
    pos: 0x32f8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  overlay23_reserved_space:
    pos: 0x3748
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  overlay23_unknown_pointer_na_238d8a0:
    pos: 0x3760
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
