meta:
  id: overlay34_data
  endian: le
  imports:
  - ../types/start_menu_items_confirm_array
  - ../types/dungeon_debug_menu_items_array
instances:
  overlay34_unknown_struct__na_22dd014:
    pos: 0xdd4
    type: u1
    repeat: expr
    repeat-expr: 0x10
    doc: |-
      1*0x4 + 3*0x4

      Note: unverified, ported from Irdkwia's notes
  start_menu_items_confirm:
    pos: 0xde4
    type: start_menu_items_confirm_array
    doc: This symbol is missing documentation.
  overlay34_unknown_struct__na_22dd03c:
    pos: 0xdfc
    type: u1
    repeat: expr
    repeat-expr: 0x10
    doc: |-
      1*0x4 + 3*0x4

      Note: unverified, ported from Irdkwia's notes
  dungeon_debug_menu_items:
    pos: 0xe0c
    type: dungeon_debug_menu_items_array
    doc: This symbol is missing documentation.
  overlay34_reserved_space:
    pos: 0xe34
    type: u1
    repeat: expr
    repeat-expr: 0xC
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay34_unknown_pointer__na_22dd080:
    pos: 0xe40
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay34_unknown_pointer__na_22dd084:
    pos: 0xe44
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay34_unknown_pointer__na_22dd088:
    pos: 0xe48
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay34_unknown_pointer__na_22dd08c:
    pos: 0xe4c
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay34_unknown_pointer__na_22dd090:
    pos: 0xe50
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
