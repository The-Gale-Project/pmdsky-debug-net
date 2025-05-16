meta:
  id: overlay23_data
  endian: le
instances:
  storage_menu_items_confirm:
    pos: 0x3214
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  storage_main_menu_items_1:
    pos: 0x322c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  storage_main_menu_items_2:
    pos: 0x324c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  storage_main_menu_items_3:
    pos: 0x326c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  storage_main_menu_items_4:
    pos: 0x328c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  storage_window_params_4:
    pos: 0x3310
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_5:
    pos: 0x3320
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_6:
    pos: 0x3330
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_7:
    pos: 0x3340
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  storage_window_params_8:
    pos: 0x3350
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
