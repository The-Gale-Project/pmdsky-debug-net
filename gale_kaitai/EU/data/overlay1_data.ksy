meta:
  id: overlay1_data
  endian: le
  imports:
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/main_menu_items_confirm_array
  - ../types/window_params
  - ../types/window_params
  - ../types/main_debug_menu_items_1_array
  - ../types/window_params
  - ../types/main_debug_menu_items_2_array
instances:
  prints_strings:
    pos: 0x11b38
    type: u1
    repeat: expr
    repeat-expr: 0x1E8
    doc: "Note: unverified, ported from Irdkwia's notes"
  prints_struct:
    pos: 0x11d20
    type: u1
    repeat: expr
    repeat-expr: 0x1F0
    doc: |-
      62*0x8

      Note: unverified, ported from Irdkwia's notes
  main_menu_window_params_1:
    pos: 0x11f24
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_2:
    pos: 0x11f34
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_3:
    pos: 0x11f44
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_4:
    pos: 0x11f54
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  continue_choice:
    pos: 0x11f74
    type: u1
    repeat: expr
    repeat-expr: 0x20
    doc: This symbol is missing documentation.
  submenu:
    pos: 0x11f94
    type: u1
    repeat: expr
    repeat-expr: 0x48
    doc: This symbol is missing documentation.
  main_menu:
    pos: 0x11fdc
    type: u1
    repeat: expr
    repeat-expr: 0xA0
    doc: This symbol is missing documentation.
  main_menu_window_params_5:
    pos: 0x12128
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_6:
    pos: 0x12138
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_7:
    pos: 0x12148
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_items_confirm:
    pos: 0x12158
    type: main_menu_items_confirm_array
    doc: This symbol is missing documentation.
  main_menu_window_params_8:
    pos: 0x121dc
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_9:
    pos: 0x121fc
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_debug_menu_items_1:
    pos: 0x1221c
    type: main_debug_menu_items_1_array
    doc: This symbol is missing documentation.
  main_menu_window_params_10:
    pos: 0x1227c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_debug_menu_items_2:
    pos: 0x1229c
    type: main_debug_menu_items_2_array
    doc: This symbol is missing documentation.
