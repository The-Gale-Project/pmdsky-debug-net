meta:
  id: overlay25_data
  endian: le
instances:
  appraisal_menu_items_confirm:
    pos: 0x1374
    size: 0x18
  appraisal_main_menu_items:
    pos: 0x138c
    size: 0x20
  appraisal_submenu_items:
    pos: 0x13ac
    size: 0x20
types:
  cart_removed_img_data_entries:
    seq:
    - id: entries
      type: u1
      repeat: eos
  script_op_code_names_entries:
    seq:
    - id: entries
      type: s1
      repeat: eos
  overlay11_debug_strings_entries:
    seq:
    - id: entries
      type: s1
      repeat: eos
  c_routine_names_entries:
    seq:
    - id: entries
      type: s1
      repeat: eos
enums: {}
