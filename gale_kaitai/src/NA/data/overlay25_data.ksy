meta:
  id: overlay25_data
  endian: le
instances:
  overlay25_unknown_struct_na_238b498:
    pos: 0x1358
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc
  appraisal_window_params_1:
    pos: 0x1364
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  appraisal_menu_items_confirm:
    pos: 0x1374
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  appraisal_main_menu_items:
    pos: 0x138c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  appraisal_submenu_items:
    pos: 0x13ac
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  overlay25_unknown_string_ids:
    pos: 0x13cc
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x28
  appraisal_window_params_2:
    pos: 0x13f4
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  appraisal_window_params_3:
    pos: 0x1404
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  appraisal_window_params_4:
    pos: 0x1414
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  appraisal_window_params_5:
    pos: 0x1424
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  appraisal_window_params_6:
    pos: 0x1434
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  appraisal_window_params_7:
    pos: 0x1444
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  appraisal_window_params_8:
    pos: 0x1454
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  overlay25_reserved_space:
    pos: 0x1484
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x1c
  overlay25_unknown_pointer_na_238b5e0:
    pos: 0x14a0
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
