meta:
  id: overlay16_data
  endian: le
instances:
  evo_menu_items_confirm:
    pos: 0x2bcc
    size: 0x18
  evo_submenu_items:
    pos: 0x2be4
    size: 0x20
  evo_main_menu_items:
    pos: 0x2c04
    size: 0x20
  evo_window_params_4:
    pos: 0x2c88
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  evo_window_params_5:
    pos: 0x2c98
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  evo_window_params_6:
    pos: 0x2ca8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
enums: {}
