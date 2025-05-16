meta:
  id: overlay16_data
  endian: le
instances:
  evo_menu_items_confirm:
    pos: 0x2bc8
    size: 0x18
  evo_submenu_items:
    pos: 0x2be0
    size: 0x20
  evo_main_menu_items:
    pos: 0x2c00
    size: 0x20
  evo_menu_string_ids:
    pos: 0x2c20
    doc: |-
      26*0x2

      Note: unverified, ported from Irdkwia's notes
    type: u2
    repeat: expr
    repeat-expr: 26
  evo_window_params_1:
    pos: 0x2c54
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  evo_window_params_2:
    pos: 0x2c64
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  evo_window_params_3:
    pos: 0x2c74
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  evo_window_params_4:
    pos: 0x2c84
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  evo_window_params_5:
    pos: 0x2c94
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  evo_window_params_6:
    pos: 0x2ca4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  evo_window_params_7:
    pos: 0x2cb4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  overlay16_reserved_space:
    pos: 0x2cf4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc
  overlay16_unknown_pointer_na_238ce40:
    pos: 0x2d00
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay16_unknown_pointer_na_238ce58:
    pos: 0x2d18
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
types: {}
enums: {}
