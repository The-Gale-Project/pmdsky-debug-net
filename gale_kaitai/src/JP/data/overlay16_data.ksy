meta:
  id: overlay16_data
  endian: le
instances:
  evo_menu_items_confirm:
    pos: 0x2be8
    size: 0x18
  evo_submenu_items:
    pos: 0x2c00
    size: 0x20
  evo_main_menu_items:
    pos: 0x2c20
    size: 0x20
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
enums: {}
