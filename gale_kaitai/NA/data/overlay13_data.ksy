meta:
  id: overlay13_data
  endian: le
  imports:
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/window_params
  - ../types/quiz_menu_items_1_array
  - ../types/starters_partner_ids_array
  - ../types/starters_hero_ids_array
  - ../types/starters_strings_array
  - ../types/quiz_question_strings_array
  - ../types/quiz_answer_strings_array
  - ../types/quiz_answer_points_array
  - ../types/window_params
  - ../types/window_params
  - ../types/quiz_debug_menu_items_array
  - ../types/quiz_question_answer_associations_array
instances:
  quiz_border_color_table:
    pos: 0x1ed0
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  portrait_attributes:
    pos: 0x1ed4
    type: u1
    repeat: expr
    repeat-expr: 0x8
    doc: "Note: unverified, ported from Irdkwia's notes"
  quiz_male_female_boost_table:
    pos: 0x1edc
    type: u1
    repeat: expr
    repeat-expr: 0x8
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay13_unknown_struct__na_238c024:
    pos: 0x1ee4
    type: u1
    repeat: expr
    repeat-expr: 0x10
    doc: "Note: unverified, ported from Irdkwia's notes"
  quiz_window_params_1:
    pos: 0x1ef4
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  quiz_window_params_2:
    pos: 0x1f04
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  quiz_window_params_3:
    pos: 0x1f14
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  quiz_window_params_4:
    pos: 0x1f24
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  quiz_menu_items_1:
    pos: 0x1f34
    type: quiz_menu_items_1_array
    doc: "Note: unverified, ported from Irdkwia's notes"
  starters_partner_ids:
    pos: 0x1f4c
    type: starters_partner_ids_array
    doc: 'type: struct monster_id_16[21]'
  starters_hero_ids:
    pos: 0x1f78
    type: starters_hero_ids_array
    doc: 'type: struct monster_id_16[32]'
  starters_type_incompatibility_table:
    pos: 0x1fb8
    type: u1
    repeat: expr
    repeat-expr: 0x54
    doc: "Note: unverified, ported from Irdkwia's notes"
  starters_strings:
    pos: 0x200c
    type: starters_strings_array
    doc: "Irdkwia's notes: InsightsStringIDs"
  quiz_question_strings:
    pos: 0x206c
    type: quiz_question_strings_array
    doc: 0x2 * (66 questions)
  quiz_answer_strings:
    pos: 0x20f0
    type: quiz_answer_strings_array
    doc: 0x2 * (175 answers + null-terminator)
  quiz_answer_points:
    pos: 0x2250
    type: quiz_answer_points_array
    doc: |-
      0x10 * (174 answers?)

      Note: unverified, ported from Irdkwia's notes
  overlay13_reserved_space:
    pos: 0x2d50
    type: u1
    repeat: expr
    repeat-expr: 0x10
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay13_unknown_pointer__na_238cea0:
    pos: 0x2d60
    type: u1
    repeat: expr
    repeat-expr: 0x4
    doc: "Note: unverified, ported from Irdkwia's notes"
  partner_select_menu_option_tracker:
    pos: 0x2d64
    type: u4
    doc: |-
      Keeps track of the currently hovered option in the partner menu to change
      the portrait when the another option is hovered.
  partner_select_menu_option_timer:
    pos: 0x2d68
    type: u4
    doc: |-
      Keeps track of how long the currently hovered option in the partner menu
      has been hovered over. Used to change the portrait to happy after some time
      has elapsed.
  quiz_window_params_5:
    pos: 0x2d6c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  quiz_window_params_6:
    pos: 0x2d7c
    type: window_params
    doc: "Note: unverified, ported from Irdkwia's notes"
  quiz_debug_menu_items:
    pos: 0x2d8c
    type: quiz_debug_menu_items_array
    doc: "Note: unverified, ported from Irdkwia's notes"
  overlay13_unknown_struct__na_238cf14:
    pos: 0x2dd4
    type: u1
    repeat: expr
    repeat-expr: 0x10
    doc: "Note: unverified, ported from Irdkwia's notes"
  quiz_question_answer_associations:
    pos: 0x2de4
    type: quiz_question_answer_associations_array
    doc: |-
      0x2 * (66 questions)

      Note: unverified, ported from Irdkwia's notes
