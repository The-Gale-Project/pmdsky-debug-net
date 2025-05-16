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
    size: 0x10
  main_menu_window_params_2:
    pos: 0x11f34
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_3:
    pos: 0x11f44
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_4:
    pos: 0x11f54
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
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
    size: 0x10
  main_menu_window_params_6:
    pos: 0x12138
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_7:
    pos: 0x12148
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_items_confirm:
    pos: 0x12158
    size: 0x18
  main_menu_window_params_8:
    pos: 0x121dc
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_9:
    pos: 0x121fc
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_debug_menu_items_1:
    pos: 0x1221c
    size: 0x60
  main_menu_window_params_10:
    pos: 0x1227c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_debug_menu_items_2:
    pos: 0x1229c
    size: 0x38
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
enums: {}
