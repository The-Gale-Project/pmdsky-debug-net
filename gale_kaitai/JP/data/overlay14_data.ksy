meta:
  id: overlay14_data
  endian: le
  imports:
  - ../types/monster_id
  - ../types/monster_id
  - ../types/sentry_debug_menu_items_array
  - ../types/pointer
  - ../types/sentry_duty_state_handler_table_array
instances:
  sentry_chatot_monster_id:
    pos: 0x2060
    type: monster_id
    doc: Monster ID for Chatot, used as the speaker ID for dialogue.
  string_id_sentry_no_more_visitors:
    pos: 0x2064
    type: s4
    doc: |-
      String ID 0x6F5:
       [se_play:0]No more visitors! No more
      visitors! ♪
  string_id_sentry_thats_all:
    pos: 0x2068
    type: s4
    doc: |-
      String ID 0x6F6:
       OK, got that![C]
       Hey, [partner] and
      [hero]![C]
       That's all for today! Now get
      back here!
  sentry_grovyle_monster_id:
    pos: 0x292c
    type: monster_id
    doc: Monster ID for Grovyle, which appears to be explicitly excluded when 
      generating species choices.
  sentry_debug_menu_items:
    pos: 0x3968
    type: sentry_debug_menu_items_array
    doc: This symbol is missing documentation.
  sentry_duty_ptr:
    pos: 0x3a40
    type: pointer
    doc: Pointer to the SENTRY_DUTY_STRUCT.
  sentry_duty_state_handler_table:
    pos: 0x3a54
    type: sentry_duty_state_handler_table_array
    doc: |-
      Null-terminated table of handler functions for the different states in the state machine. See SentryRunState.

      type: state_handler_fn_t[35]
