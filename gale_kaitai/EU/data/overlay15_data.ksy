meta:
  id: overlay15_data
  endian: le
  imports:
  - ../types/bank_main_menu_items_array
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
instances:
  bank_main_menu_items:
    pos: 0xf40
    type: bank_main_menu_items_array
    doc: This symbol is missing documentation.
  bank_window_params_2:
    pos: 0xf78
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bank_window_params_3:
    pos: 0xf88
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bank_window_params_4:
    pos: 0xf98
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
