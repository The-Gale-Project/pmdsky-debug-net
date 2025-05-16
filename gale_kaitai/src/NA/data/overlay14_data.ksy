meta:
  id: overlay14_data
  endian: le
instances:
  sentry_duty_struct_size:
    pos: 0x3c4
    doc: Number of bytes in the sentry duty struct (14548).
    type: u4
  sentry_loudred_monster_id:
    pos: 0x200c
    doc: Monster ID for Loudred, used as the speaker ID for dialogue.
    size: 0x4
  string_id_sentry_top_sessions:
    pos: 0x2010
    doc: |-
      String ID 0x6D9:
       Here are the rankings for the
      top sentry sessions.
    type: s4
  string_id_sentry_instructions:
    pos: 0x2014
    doc: |-
      String ID 0x6D8:
       Look at the footprint on the top
      screen, OK? Then identify the Pokémon![C]
       You can get only [CS:V]two wrong[CR], OK?
      [partner] will keep an eye on things!
    type: s4
  string_id_sentry_here_comes:
    pos: 0x2018
    doc: |-
      String ID 0x6DA:
       Here comes a Pokémon! Check
      its footprint and tell me what it is!
    type: s4
  string_id_sentry_whose_footprint:
    pos: 0x201c
    doc: |-
      String ID 0x6DB:
       Whose footprint is this?[W:60]
    type: s4
  string_id_sentry_try_again:
    pos: 0x2024
    doc: |-
      String ID 0x6EB:
       Huh? I don't think so. Try again!
    type: s4
  string_id_sentry_out_of_time:
    pos: 0x2028
    doc: |-
      String ID 0x6DC:
       [se_play:0][W:30]Out of time! Pick up the pace![W:75]
    type: s4
  string_id_sentry_footprint_is_6ee:
    pos: 0x202c
    doc: |-
      String ID 0x6EE:
       The footprint is [kind:]'s!
      The footprint is [kind:]'s![W:60]
    type: s4
  string_id_sentry_come_in_6ef:
    pos: 0x2030
    doc: |-
      String ID 0x6EF:
       Heard ya! Come in, visitor![W:30]
    type: s4
  string_id_sentry_wrong:
    pos: 0x2038
    doc: |-
      String ID 0x6F1:
       ......[se_play:0][W:30]Huh?! Looks wrong to me![W:50]
    type: s4
  string_id_sentry_buck_up:
    pos: 0x203c
    doc: |-
      String ID 0x6F2 (and also used as Loudred's speaker ID after subtracting 0x5B0):
       The correct answer is
      [kind:]! Buck up! And snap to it![se_play:0][W:120]
    type: s4
  string_id_sentry_footprint_is_6ec:
    pos: 0x2044
    doc: |-
      String ID 0x6EC:
       The footprint is [kind:]'s!
      The footprint is [kind:]'s![W:60]
    type: s4
  string_id_sentry_come_in_6ed:
    pos: 0x2048
    doc: |-
      String ID 0x6ED:
       Heard ya! Come in, visitor![W:30]
    type: s4
  string_id_sentry_keep_you_waiting:
    pos: 0x2050
    doc: |-
      String ID 0x6F3:
       [se_play:0]Sorry to keep you waiting.
    type: s4
  string_id_sentry_thatll_do_it:
    pos: 0x2054
    doc: |-
      String ID 0x6F4:
       [partner] and [hero]![C]
       That'll do it! Now get back here!
    type: s4
  sentry_chatot_monster_id:
    pos: 0x2058
    doc: Monster ID for Chatot, used as the speaker ID for dialogue.
    size: 0x4
  string_id_sentry_no_more_visitors:
    pos: 0x205c
    doc: |-
      String ID 0x6F5:
       [se_play:0]No more visitors! No more
      visitors! ♪
    type: s4
  string_id_sentry_thats_all:
    pos: 0x2060
    doc: |-
      String ID 0x6F6:
       OK, got that![C]
       Hey, [partner] and
      [hero]![C]
       That's all for today! Now get
      back here!
    type: s4
  sentry_grovyle_monster_id:
    pos: 0x2924
    doc: Monster ID for Grovyle, which appears to be explicitly excluded when generating
      species choices.
    size: 0x4
  sentry_debug_menu_items:
    pos: 0x3960
    size: 0x48
  sentry_duty_ptr:
    pos: 0x3a40
    doc: Pointer to the SENTRY_DUTY_STRUCT.
    type: u4
  sentry_duty_state_handler_table:
    pos: 0x3a54
    doc: |-
      Null-terminated table of handler functions for the different states in the state machine. See SentryRunState.

      type: state_handler_fn_t[35]
    size: 0x8c
types: {}
enums: {}
