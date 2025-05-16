meta:
  id: overlay17_data
  endian: le
instances:
  assembly_menu_items_confirm:
    pos: 0x1a40
    size: 0x18
  assembly_main_menu_items_1:
    pos: 0x1a58
    size: 0x18
  assembly_main_menu_items_2:
    pos: 0x1a70
    size: 0x20
  assembly_submenu_items_1:
    pos: 0x1a90
    size: 0x28
  assembly_submenu_items_2:
    pos: 0x1ab8
    size: 0x30
  assembly_submenu_items_3:
    pos: 0x1ae8
    size: 0x30
  assembly_submenu_items_4:
    pos: 0x1b18
    size: 0x38
  assembly_submenu_items_5:
    pos: 0x1b50
    size: 0x38
  assembly_submenu_items_6:
    pos: 0x1b88
    size: 0x38
  assembly_submenu_items_7:
    pos: 0x1bc0
    size: 0x40
  overlay17_function_pointer_table:
    pos: 0x1c00
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: u4
    repeat: expr
    repeat-expr: 42
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
enums: {}
