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
    pos: 0x11c0c
    type: u1
    repeat: expr
    repeat-expr: 0x1E8
    doc: "Note: unverified, ported from Irdkwia's notes"
  prints_struct:
    pos: 0x11df4
    type: u1
    repeat: expr
    repeat-expr: 0x1F0
    doc: |-
      62*0x8

      Note: unverified, ported from Irdkwia's notes
  main_menu_window_params_1:
    pos: 0x11ff8
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_2:
    pos: 0x12008
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_3:
    pos: 0x12018
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_4:
    pos: 0x12028
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  continue_choice:
    pos: 0x12048
    type: u1
    repeat: expr
    repeat-expr: 0x20
    doc: This symbol is missing documentation.
  submenu:
    pos: 0x12068
    type: u1
    repeat: expr
    repeat-expr: 0x48
    doc: This symbol is missing documentation.
  main_menu:
    pos: 0x120b0
    type: u1
    repeat: expr
    repeat-expr: 0xA0
    doc: This symbol is missing documentation.
  main_menu_window_params_5:
    pos: 0x121fc
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_6:
    pos: 0x1220c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_7:
    pos: 0x1221c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_items_confirm:
    pos: 0x1222c
    type: main_menu_items_confirm_array
    doc: This symbol is missing documentation.
  main_menu_window_params_8:
    pos: 0x122b0
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_menu_window_params_9:
    pos: 0x122d0
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_debug_menu_items_1:
    pos: 0x122f0
    type: main_debug_menu_items_1_array
    doc: This symbol is missing documentation.
  main_menu_window_params_10:
    pos: 0x12350
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  main_debug_menu_items_2:
    pos: 0x12370
    type: main_debug_menu_items_2_array
    doc: This symbol is missing documentation.
