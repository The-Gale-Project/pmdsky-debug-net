meta:
  id: overlay25_data
  endian: le
instances:
  appraisal_window_params_1:
    pos: 0x1364
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  appraisal_menu_items_confirm:
    pos: 0x1374
    size: 0x18
  appraisal_main_menu_items:
    pos: 0x138c
    size: 0x20
  appraisal_submenu_items:
    pos: 0x13ac
    size: 0x20
  appraisal_window_params_5:
    pos: 0x1424
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  appraisal_window_params_6:
    pos: 0x1434
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  appraisal_window_params_7:
    pos: 0x1444
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  appraisal_window_params_8:
    pos: 0x1454
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
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
