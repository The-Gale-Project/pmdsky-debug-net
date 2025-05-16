meta:
  id: overlay1_data
  endian: le
instances:
  prints_strings:
    pos: 0x11b38
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x1e8
  prints_struct:
    pos: 0x11d20
    doc: |-
      62*0x8

      Note: unverified, ported from Irdkwia's notes
    size: 0x1f0
  main_menu_window_params_1:
    pos: 0x11f24
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_2:
    pos: 0x11f34
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_3:
    pos: 0x11f44
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_4:
    pos: 0x11f54
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  continue_choice:
    pos: 0x11f74
    size: 0x20
  submenu:
    pos: 0x11f94
    size: 0x48
  main_menu:
    pos: 0x11fdc
    size: 0xa0
  main_menu_window_params_5:
    pos: 0x12128
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_6:
    pos: 0x12138
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_7:
    pos: 0x12148
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_items_confirm:
    pos: 0x12158
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  main_menu_window_params_8:
    pos: 0x121dc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_menu_window_params_9:
    pos: 0x121fc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_debug_menu_items_1:
    pos: 0x1221c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 12
  main_menu_window_params_10:
    pos: 0x1227c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  main_debug_menu_items_2:
    pos: 0x1229c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 7
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
