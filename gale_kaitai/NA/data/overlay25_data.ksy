meta:
  id: overlay25_data
  endian: le
  imports:
  - ../types/window_params
  - ../types/appraisal_menu_items_confirm_array
  - ../types/appraisal_main_menu_items_array
  - ../types/appraisal_submenu_items_array
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
instances:
  overlay25_unknown_struct__na_238b498:
    pos: 0x1358
    type: u1
    repeat: expr
    repeat-expr: 0xC
    doc: "Note: unverified, ported from Irdkwia's notes"
  appraisal_window_params_1:
    pos: 0x1364
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  appraisal_menu_items_confirm:
    pos: 0x1374
    type: appraisal_menu_items_confirm_array
    doc: This symbol is missing documentation.
  appraisal_main_menu_items:
    pos: 0x138c
    type: appraisal_main_menu_items_array
    doc: This symbol is missing documentation.
  appraisal_submenu_items:
    pos: 0x13ac
    type: appraisal_submenu_items_array
    doc: This symbol is missing documentation.
  overlay25_unknown_string_ids:
    pos: 0x13cc
    type: u1
    repeat: expr
    repeat-expr: 0x28
    doc: "Note: unverified, ported from Irdkwia's notes"
  appraisal_window_params_2:
    pos: 0x13f4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  appraisal_window_params_3:
    pos: 0x1404
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  appraisal_window_params_4:
    pos: 0x1414
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  appraisal_window_params_5:
    pos: 0x1424
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  appraisal_window_params_6:
    pos: 0x1434
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  appraisal_window_params_7:
    pos: 0x1444
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  appraisal_window_params_8:
    pos: 0x1454
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay25_reserved_space:
    pos: 0x1484
    type: u1
    repeat: expr
    repeat-expr: 0x1C
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay25_unknown_pointer__na_238b5e0:
    pos: 0x14a0
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
