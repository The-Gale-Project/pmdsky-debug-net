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
  main_menu_window_params_1:
    pos: 0x120d8
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_2:
    pos: 0x120e8
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_3:
    pos: 0x120f8
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_4:
    pos: 0x12108
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  continue_choice:
    pos: 0x12128
    type: u1
    repeat: expr
    repeat-expr: 0x20
    doc: This symbol is missing documentation.
  submenu:
    pos: 0x12148
    type: u1
    repeat: expr
    repeat-expr: 0x48
    doc: This symbol is missing documentation.
  main_menu:
    pos: 0x12190
    type: u1
    repeat: expr
    repeat-expr: 0xA0
    doc: This symbol is missing documentation.
  main_menu_window_params_5:
    pos: 0x122d4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_6:
    pos: 0x122e4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_7:
    pos: 0x122f4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_items_confirm:
    pos: 0x12304
    type: main_menu_items_confirm_array
    doc: This symbol is missing documentation.
  main_menu_window_params_8:
    pos: 0x12388
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_9:
    pos: 0x123a8
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_debug_menu_items_1:
    pos: 0x123c8
    type: main_debug_menu_items_1_array
    doc: This symbol is missing documentation.
  main_menu_window_params_10:
    pos: 0x12428
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_debug_menu_items_2:
    pos: 0x12448
    type: main_debug_menu_items_2_array
    doc: This symbol is missing documentation.
