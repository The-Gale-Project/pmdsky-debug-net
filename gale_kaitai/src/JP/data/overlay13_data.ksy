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
    size: 0x10
  quiz_window_params_2:
    pos: 0x1f0c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  quiz_window_params_3:
    pos: 0x1f1c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  quiz_window_params_4:
    pos: 0x1f2c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  quiz_menu_items_1:
    pos: 0x1f3c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x18
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
    size: 0xae0
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
    size: 0x10
  quiz_window_params_6:
    pos: 0x2d7c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x10
  quiz_debug_menu_items:
    pos: 0x2d8c
    doc: "Note: unverified, ported from Irdkwia's notes"
    size: 0x48
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
types: {}
enums: {}
