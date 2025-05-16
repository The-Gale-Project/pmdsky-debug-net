meta:
  id: overlay1_data
  endian: le
instances:
  prints_strings:
    pos: 0x11c0c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x1e8
  prints_struct:
    pos: 0x11df4
    doc: |-
      62*0x8

      Note: unverified, ported from Irdkwia's notes
    size: 0x1f0
  main_menu_window_params_1:
    pos: 0x11ff8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_2:
    pos: 0x12008
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_3:
    pos: 0x12018
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_4:
    pos: 0x12028
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  continue_choice:
    pos: 0x12048
    size: 0x20
  submenu:
    pos: 0x12068
    size: 0x48
  main_menu:
    pos: 0x120b0
    size: 0xa0
  main_menu_window_params_5:
    pos: 0x121fc
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_6:
    pos: 0x1220c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_7:
    pos: 0x1221c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_items_confirm:
    pos: 0x1222c
    size: 0x18
  main_menu_window_params_8:
    pos: 0x122b0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_menu_window_params_9:
    pos: 0x122d0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_debug_menu_items_1:
    pos: 0x122f0
    size: 0x60
  main_menu_window_params_10:
    pos: 0x12350
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  main_debug_menu_items_2:
    pos: 0x12370
    size: 0x38
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
enums: {}
