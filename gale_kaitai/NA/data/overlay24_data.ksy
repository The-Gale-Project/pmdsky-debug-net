meta:
  id: overlay24_data
  endian: le
  imports:
  - ../types/daycare_menu_items_confirm_array
  - ../types/daycare_main_menu_items_array
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
instances:
  overlay24_unknown_struct__na_238c508:
    pos: 0x23c8
    type: u1
    repeat: expr
    repeat-expr: 0xC
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay24_unknown_struct__na_238c514:
    pos: 0x23d4
    type: u1
    repeat: expr
    repeat-expr: 0xC
    doc: "Note: unverified, ported from Irdkwia's notes"
  daycare_menu_items_confirm:
    pos: 0x23e0
    type: daycare_menu_items_confirm_array
    doc: This symbol is missing documentation.
  daycare_main_menu_items:
    pos: 0x23f8
    type: daycare_main_menu_items_array
    doc: This symbol is missing documentation.
  overlay24_unknown_string_ids:
    pos: 0x2418
    type: u1
    repeat: expr
    repeat-expr: 0x38
    doc: "Note: unverified, ported from Irdkwia's notes"
  daycare_window_params_1:
    pos: 0x2450
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  daycare_window_params_2:
    pos: 0x2460
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  daycare_window_params_3:
    pos: 0x2470
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  daycare_window_params_4:
    pos: 0x2480
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  daycare_window_params_5:
    pos: 0x2490
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay24_reserved_space:
    pos: 0x24a0
    type: u1
    repeat: expr
    repeat-expr: 0x20
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay24_unknown_pointer__na_238c600:
    pos: 0x24c0
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
