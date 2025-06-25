meta:
  id: overlay16_data
  endian: le
  imports:
  - ../types/evo_menu_items_confirm_array
  - ../types/evo_submenu_items_array
  - ../types/evo_main_menu_items_array
  - ../types/evo_menu_string_ids_array
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
instances:
  evo_menu_items_confirm:
    pos: 0x2bc8
    type: evo_menu_items_confirm_array
    doc: This symbol is missing documentation.
  evo_submenu_items:
    pos: 0x2be0
    type: evo_submenu_items_array
    doc: This symbol is missing documentation.
  evo_main_menu_items:
    pos: 0x2c00
    type: evo_main_menu_items_array
    doc: This symbol is missing documentation.
  evo_menu_string_ids:
    pos: 0x2c20
    type: evo_menu_string_ids_array
    doc: |-
      26*0x2

      Note: unverified, ported from Irdkwia's notes
  evo_window_params_1:
    pos: 0x2c54
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  evo_window_params_2:
    pos: 0x2c64
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  evo_window_params_3:
    pos: 0x2c74
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  evo_window_params_4:
    pos: 0x2c84
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  evo_window_params_5:
    pos: 0x2c94
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  evo_window_params_6:
    pos: 0x2ca4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  evo_window_params_7:
    pos: 0x2cb4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay16_reserved_space:
    pos: 0x2cf4
    type: u1
    repeat: expr
    repeat-expr: 0xC
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay16_unknown_pointer__na_238ce40:
    pos: 0x2d00
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay16_unknown_pointer__na_238ce58:
    pos: 0x2d18
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
