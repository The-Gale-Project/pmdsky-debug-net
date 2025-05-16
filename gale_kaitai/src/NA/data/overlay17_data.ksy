meta:
  id: overlay17_data
  endian: le
instances:
  assembly_window_params_1:
    pos: 0x19f4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  assembly_window_params_2:
    pos: 0x1a04
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  assembly_window_params_3:
    pos: 0x1a14
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  assembly_window_params_4:
    pos: 0x1a24
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  assembly_window_params_5:
    pos: 0x1a34
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  assembly_menu_items_confirm:
    pos: 0x1a44
    size: 0x18
  assembly_main_menu_items_1:
    pos: 0x1a5c
    size: 0x18
  assembly_main_menu_items_2:
    pos: 0x1a74
    size: 0x20
  assembly_submenu_items_1:
    pos: 0x1a94
    size: 0x28
  assembly_submenu_items_2:
    pos: 0x1abc
    size: 0x30
  assembly_submenu_items_3:
    pos: 0x1aec
    size: 0x30
  assembly_submenu_items_4:
    pos: 0x1b1c
    size: 0x38
  assembly_submenu_items_5:
    pos: 0x1b54
    size: 0x38
  assembly_submenu_items_6:
    pos: 0x1b8c
    size: 0x38
  assembly_submenu_items_7:
    pos: 0x1bc4
    size: 0x40
  overlay17_function_pointer_table:
    pos: 0x1c04
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: u4
    repeat: expr
    repeat-expr: 42
  overlay17_reserved_space:
    pos: 0x1cac
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x14
  overlay17_unknown_pointer_na_238be00:
    pos: 0x1cc0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay17_unknown_pointer_na_238be04:
    pos: 0x1cc4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay17_unknown_pointer_na_238be08:
    pos: 0x1cc8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
enums: {}
