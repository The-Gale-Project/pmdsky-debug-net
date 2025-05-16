meta:
  id: overlay34_data
  endian: le
instances:
  overlay34_unknown_struct_na_22dd014:
    pos: 0xdd4
    doc: |-
      1*0x4 + 3*0x4

      Note: unverified, ported from Irdkwia's notes
    size: 0x10
  start_menu_items_confirm:
    pos: 0xde4
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  overlay34_unknown_struct_na_22dd03c:
    pos: 0xdfc
    doc: |-
      1*0x4 + 3*0x4

      Note: unverified, ported from Irdkwia's notes
    size: 0x10
  dungeon_debug_menu_items:
    pos: 0xe0c
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 5
  overlay34_reserved_space:
    pos: 0xe34
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc
  overlay34_unknown_pointer_na_22dd080:
    pos: 0xe40
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay34_unknown_pointer_na_22dd084:
    pos: 0xe44
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay34_unknown_pointer_na_22dd088:
    pos: 0xe48
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay34_unknown_pointer_na_22dd08c:
    pos: 0xe4c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay34_unknown_pointer_na_22dd090:
    pos: 0xe50
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
types:
  simple_menu_id_item:
  - id: string_id
    type: u2
  - id: _padding
    type: u2
  - id: result_value
    type: s4
enums: {}
