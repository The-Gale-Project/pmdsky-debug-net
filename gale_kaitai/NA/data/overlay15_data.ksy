meta:
  id: overlay15_data
  endian: le
  imports:
  - ../types/bank_main_menu_items_array
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
instances:
  bank_main_menu_items:
    pos: 0xf14
    type: bank_main_menu_items_array
    doc: This symbol is missing documentation.
  bank_window_params_1:
    pos: 0xf3c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bank_window_params_2:
    pos: 0xf4c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bank_window_params_3:
    pos: 0xf5c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bank_window_params_4:
    pos: 0xf6c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bank_window_params_5:
    pos: 0xf7c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay15_reserved_space:
    pos: 0x1024
    type: u1
    repeat: expr
    repeat-expr: 0x1C
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay15_unknown_pointer__na_238b180:
    pos: 0x1040
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
