meta:
  id: overlay24_data
  endian: le
  imports:
  - ../types/daycare_menu_items_confirm_array
  - ../types/daycare_main_menu_items_array
  - ../types/window_params
instances:
  daycare_menu_items_confirm:
    pos: 0x23e0
    type: daycare_menu_items_confirm_array
    doc: This symbol is missing documentation.
  daycare_main_menu_items:
    pos: 0x23f8
    type: daycare_main_menu_items_array
    doc: This symbol is missing documentation.
  daycare_window_params_4:
    pos: 0x2480
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
