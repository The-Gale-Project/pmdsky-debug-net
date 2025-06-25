meta:
  id: overlay19_data
  endian: le
  imports:
  - ../types/bar_unlockable_dungeons_table_array
  - ../types/bar_recruitable_monster_table_array
  - ../types/bar_available_items_array
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/bar_menu_items_confirm_1_array
  - ../types/bar_menu_items_confirm_2_array
  - ../types/bar_main_menu_items_array
  - ../types/bar_submenu_items_1_array
  - ../types/bar_submenu_items_2_array
instances:
  overlay19_unknown_table__na_238dae0:
    pos: 0x39a0
    type: u1
    repeat: expr
    repeat-expr: 0x8
    doc: |-
      4*0x2

      Note: unverified, ported from Irdkwia's notes
  bar_unlockable_dungeons_table:
    pos: 0x39a8
    type: bar_unlockable_dungeons_table_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct dungeon_id_16[6]
  bar_recruitable_monster_table:
    pos: 0x39b4
    type: bar_recruitable_monster_table_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct monster_id_16[108]
  bar_available_items:
    pos: 0x3a8c
    type: bar_available_items_array
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct bar_item[66]
  overlay19_unknown_string_ids__na_238e178:
    pos: 0x4038
    type: u1
    repeat: expr
    repeat-expr: 0x2C
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay19_unknown_struct__na_238e1a4:
    pos: 0x4064
    type: u1
    repeat: expr
    repeat-expr: 0x28
    doc: |-
      5*0x8

      Note: unverified, ported from Irdkwia's notes
  overlay19_unknown_string_ids__na_238e1cc:
    pos: 0x408c
    type: u1
    repeat: expr
    repeat-expr: 0xC
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_window_params_1:
    pos: 0x4098
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_window_params_2:
    pos: 0x40a8
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_window_params_3:
    pos: 0x40b8
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_menu_items_confirm_1:
    pos: 0x40c8
    type: bar_menu_items_confirm_1_array
    doc: This symbol is missing documentation.
  bar_menu_items_confirm_2:
    pos: 0x40e0
    type: bar_menu_items_confirm_2_array
    doc: This symbol is missing documentation.
  overlay19_unknown_string_ids__na_238e238:
    pos: 0x40f8
    type: u1
    repeat: expr
    repeat-expr: 0x18
    doc: "Note: unverified, ported from Irdkwia's notes"
  bar_main_menu_items:
    pos: 0x4110
    type: bar_main_menu_items_array
    doc: This symbol is missing documentation.
  bar_submenu_items_1:
    pos: 0x4130
    type: bar_submenu_items_1_array
    doc: This symbol is missing documentation.
  bar_submenu_items_2:
    pos: 0x4150
    type: bar_submenu_items_2_array
    doc: This symbol is missing documentation.
  overlay19_reserved_space:
    pos: 0x4204
    type: u1
    repeat: expr
    repeat-expr: 0x1C
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay19_unknown_pointer__na_238e360:
    pos: 0x4220
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay19_unknown_pointer__na_238e364:
    pos: 0x4224
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
