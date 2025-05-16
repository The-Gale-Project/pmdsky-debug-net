meta:
  id: overlay19_data
  endian: le
instances:
  overlay19_unknown_table_na_238dae0:
    pos: 0x39a0
    doc: |-
      4*0x2

      Note: unverified, ported from Irdkwia's notes
    size: 0x8
  bar_unlockable_dungeons_table:
    pos: 0x39a8
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct dungeon_id_16[6]
    size: 0xc
  bar_recruitable_monster_table:
    pos: 0x39b4
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct monster_id_16[108]
    size: 0xd8
  bar_available_items:
    pos: 0x3a8c
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct bar_item[66]
    type: bar_item
    repeat: expr
    repeat-expr: 66
  overlay19_unknown_string_ids_na_238e178:
    pos: 0x4038
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x2c
  overlay19_unknown_struct_na_238e1a4:
    pos: 0x4064
    doc: |-
      5*0x8

      Note: unverified, ported from Irdkwia's notes
    size: 0x28
  overlay19_unknown_string_ids_na_238e1cc:
    pos: 0x408c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc
  bar_window_params_1:
    pos: 0x4098
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bar_window_params_2:
    pos: 0x40a8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bar_window_params_3:
    pos: 0x40b8
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bar_menu_items_confirm_1:
    pos: 0x40c8
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  bar_menu_items_confirm_2:
    pos: 0x40e0
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  overlay19_unknown_string_ids_na_238e238:
    pos: 0x40f8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
  bar_main_menu_items:
    pos: 0x4110
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  bar_submenu_items_1:
    pos: 0x4130
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  bar_submenu_items_2:
    pos: 0x4150
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 6
  overlay19_reserved_space:
    pos: 0x4204
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x1c
  overlay19_unknown_pointer_na_238e360:
    pos: 0x4220
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay19_unknown_pointer_na_238e364:
    pos: 0x4224
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
types:
  bar_item:
  - id: id
    type: item_id_16
  - id: field_0x2
    type: s2
  - id: field_0x4
    type: s2
  - id: field_0x6
    type: s2
  - id: field_0x8
    type: s2
  - id: field_0xa
    type: s2
  - id: field_0xc
    type: s2
  window_params:
  - id: update
    type: update_window_fn_t
  - id: x_offset
    type: u1
  - id: y_offset
    type: u1
  - id: width
    type: u1
  - id: height
    type: u1
  - id: screen
    type: screen_8
  - id: box_type
    type: box_type_8
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  simple_menu_id_item:
  - id: string_id
    type: u2
  - id: _padding
    type: u2
  - id: result_value
    type: s4
enums: {}
