meta:
  id: overlay13_data
  endian: le
instances:
  quiz_border_color_table:
    pos: 0x1ed8
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  portrait_attributes:
    pos: 0x1edc
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x8
  quiz_male_female_boost_table:
    pos: 0x1ee4
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x8
  overlay13_unknown_struct_na_238c024:
    pos: 0x1eec
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  quiz_window_params_1:
    pos: 0x1efc
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  quiz_window_params_2:
    pos: 0x1f0c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  quiz_window_params_3:
    pos: 0x1f1c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  quiz_window_params_4:
    pos: 0x1f2c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  quiz_menu_items_1:
    pos: 0x1f3c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 3
  starters_partner_ids:
    pos: 0x1f54
    doc: 'type: struct monster_id_16[21]'
    size: 0x2a
  starters_hero_ids:
    pos: 0x1f80
    doc: 'type: struct monster_id_16[32]'
    size: 0x40
  starters_type_incompatibility_table:
    pos: 0x1fc0
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x54
  starters_strings:
    pos: 0x2014
    doc: "Irdkwia's notes: InsightsStringIDs"
    type: u2
    repeat: expr
    repeat-expr: 48
  quiz_question_strings:
    pos: 0x2074
    doc: 0x2 * (66 questions)
    type: u2
    repeat: expr
    repeat-expr: 66
  quiz_answer_strings:
    pos: 0x20f8
    doc: 0x2 * (175 answers + null-terminator)
    type: u2
    repeat: expr
    repeat-expr: 176
  quiz_answer_points:
    pos: 0x2258
    doc: |-
      0x10 * (174 answers?)

      Note: unverified, ported from Irdkwia's notes
    type: quiz_answer_points_entry
    repeat: expr
    repeat-expr: 174
  overlay13_reserved_space:
    pos: 0x2d58
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  overlay13_unknown_pointer_na_238cea0:
    pos: 0x2d60
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x4
  partner_select_menu_option_tracker:
    pos: 0x2d64
    doc: |-
      Keeps track of the currently hovered option in the partner menu to change
      the portrait when the another option is hovered.
    type: u4
  partner_select_menu_option_timer:
    pos: 0x2d70
    doc: |-
      Keeps track of how long the currently hovered option in the partner menu
      has been hovered over. Used to change the portrait to happy after some time
      has elapsed.
    type: u4
  quiz_window_params_5:
    pos: 0x2d6c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  quiz_window_params_6:
    pos: 0x2d7c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: window_params
  quiz_debug_menu_items:
    pos: 0x2d8c
    doc: "Note: unverified, ported from Irdkwia's notes"
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 9
  overlay13_unknown_struct_na_238cf14:
    pos: 0x2ddc
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  quiz_question_answer_associations:
    pos: 0x2de4
    doc: |-
      0x2 * (66 questions)

      Note: unverified, ported from Irdkwia's notes
    type: u2
    repeat: expr
    repeat-expr: 66
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
  quiz_answer_points_entry:
  - id: field_0x0
    type: u1
  - id: field_0x1
    type: u1
  - id: field_0x2
    type: u1
  - id: field_0x3
    type: u1
  - id: field_0x4
    type: u1
  - id: field_0x5
    type: u1
  - id: field_0x6
    type: u1
  - id: field_0x7
    type: u1
  - id: field_0x8
    type: u1
  - id: field_0x9
    type: u1
  - id: field_0xa
    type: u1
  - id: field_0xb
    type: u1
  - id: field_0xc
    type: u1
  - id: field_0xd
    type: u1
  - id: field_0xe
    type: u1
  - id: field_0xf
    type: u1
enums: {}
