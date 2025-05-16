meta:
  id: overlay22_data
  endian: le
instances:
  shop_window_params_1:
    pos: 0x46dc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_2:
    pos: 0x46fc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  overlay22_unknown_struct_na_238e85c:
    pos: 0x471c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0xc
  shop_menu_items_confirm:
    pos: 0x4728
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  shop_main_menu_items_1:
    pos: 0x4740
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  shop_main_menu_items_2:
    pos: 0x4760
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 4
  shop_main_menu_items_3:
    pos: 0x4780
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 6
  overlay22_unknown_string_ids:
    pos: 0x47b0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x60
  shop_window_params_3:
    pos: 0x4810
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_4:
    pos: 0x4820
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_5:
    pos: 0x4830
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_6:
    pos: 0x4840
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_7:
    pos: 0x4850
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_8:
    pos: 0x4860
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_9:
    pos: 0x4870
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  shop_window_params_10:
    pos: 0x4880
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  overlay22_reserved_space:
    pos: 0x4b18
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x8
  overlay22_unknown_pointer_na_238ec60:
    pos: 0x4b20
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay22_unknown_pointer_na_238ec64:
    pos: 0x4b24
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay22_unknown_pointer_na_238ec68:
    pos: 0x4b28
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay22_unknown_pointer_na_238ec6c:
    pos: 0x4b2c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  overlay22_unknown_pointer_na_238ec70:
    pos: 0x4b30
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
types:
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
