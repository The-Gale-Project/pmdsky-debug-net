meta:
  id: overlay1_data
  endian: le
instances:
  continue_choice:
    pos: 0x12128
    size: 0x20
  submenu:
    pos: 0x12148
    size: 0x48
  main_menu:
    pos: 0x12190
    size: 0xa0
  main_debug_menu_items_1:
    pos: 0x123c8
    size: 0x60
  main_debug_menu_items_2:
    pos: 0x12448
    size: 0x38
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
enums: {}
