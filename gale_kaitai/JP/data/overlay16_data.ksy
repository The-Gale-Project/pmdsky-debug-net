meta:
  id: overlay16_data
  endian: le
  imports:
  - ../types/evo_menu_items_confirm_array
  - ../types/evo_submenu_items_array
  - ../types/evo_main_menu_items_array
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
instances:
  evo_menu_items_confirm:
    pos: 0x2be8
    type: evo_menu_items_confirm_array
    doc: This symbol is missing documentation.
  evo_submenu_items:
    pos: 0x2c00
    type: evo_submenu_items_array
    doc: This symbol is missing documentation.
  evo_main_menu_items:
    pos: 0x2c20
    type: evo_main_menu_items_array
    doc: This symbol is missing documentation.
  evo_window_params_4:
    pos: 0x2ca4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  evo_window_params_5:
    pos: 0x2cb4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  evo_window_params_6:
    pos: 0x2cc4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
