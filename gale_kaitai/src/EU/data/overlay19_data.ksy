meta:
  id: overlay19_data
  endian: le
instances:
  bar_available_items:
    pos: 0x3a80
    doc: |-
      Note: unverified, ported from Irdkwia's notes

      type: struct bar_item[66]
    type: bar_item
    repeat: expr
    repeat-expr: 66
  bar_window_params_1:
    pos: 0x408c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bar_window_params_2:
    pos: 0x409c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bar_window_params_3:
    pos: 0x40ac
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  bar_menu_items_confirm_1:
    pos: 0x40bc
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  bar_menu_items_confirm_2:
    pos: 0x40d4
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  bar_main_menu_items:
    pos: 0x4104
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  bar_submenu_items_1:
    pos: 0x4124
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  bar_submenu_items_2:
    pos: 0x4144
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 6
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
