meta:
  id: overlay14_data
  endian: le
instances:
  sentry_chatot_monster_id:
    pos: 0x2060
    doc: Monster ID for Chatot, used as the speaker ID for dialogue.
    size: 0x4
  string_id_sentry_no_more_visitors:
    pos: 0x2064
    doc: |-
      String ID 0x6F5:
       [se_play:0]No more visitors! No more
      visitors! ♪
    type: s4
  string_id_sentry_thats_all:
    pos: 0x2068
    doc: |-
      String ID 0x6F6:
       OK, got that![C]
       Hey, [partner] and
      [hero]![C]
       That's all for today! Now get
      back here!
    type: s4
  sentry_grovyle_monster_id:
    pos: 0x292c
    doc: Monster ID for Grovyle, which appears to be explicitly excluded when generating
      species choices.
    size: 0x4
  sentry_debug_menu_items:
    pos: 0x3968
    type: simple_menu_id_item
    repeat: expr
    repeat-expr: 9
  sentry_duty_ptr:
    pos: 0x3a40
    doc: Pointer to the SENTRY_DUTY_STRUCT.
    type: u4
types:
  simple_menu_id_item:
  - id: string_id
    type: u2
  - id: _padding
    type: u2
  - id: result_value
    type: s4
enums: {}
