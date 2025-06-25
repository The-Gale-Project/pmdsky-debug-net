meta:
  id: overlay14_data
  endian: le
  imports:
  - ../types/monster_id
  - ../types/monster_id
  - ../types/monster_id
  - ../types/sentry_debug_menu_items_array
  - ../types/pointer
  - ../types/sentry_duty_state_handler_table_array
instances:
  sentry_duty_struct_size:
    pos: 0x3c4
    type: u4
    doc: Number of bytes in the sentry duty struct (14548).
  sentry_loudred_monster_id:
    pos: 0x200c
    type: monster_id
    doc: Monster ID for Loudred, used as the speaker ID for dialogue.
  string_id_sentry_top_sessions:
    pos: 0x2010
    type: s4
    doc: |-
      String ID 0x6D9:
       Here are the rankings for the
      top sentry sessions.
  string_id_sentry_instructions:
    pos: 0x2014
    type: s4
    doc: |-
      String ID 0x6D8:
       Look at the footprint on the top
      screen, OK? Then identify the Pokémon![C]
       You can get only [CS:V]two wrong[CR], OK?
      [partner] will keep an eye on things!
  string_id_sentry_here_comes:
    pos: 0x2018
    type: s4
    doc: |-
      String ID 0x6DA:
       Here comes a Pokémon! Check
      its footprint and tell me what it is!
  string_id_sentry_whose_footprint:
    pos: 0x201c
    type: s4
    doc: |-
      String ID 0x6DB:
       Whose footprint is this?[W:60]
  string_id_sentry_try_again:
    pos: 0x2024
    type: s4
    doc: |-
      String ID 0x6EB:
       Huh? I don't think so. Try again!
  string_id_sentry_out_of_time:
    pos: 0x2028
    type: s4
    doc: |-
      String ID 0x6DC:
       [se_play:0][W:30]Out of time! Pick up the pace![W:75]
  string_id_sentry_footprint_is_6ee:
    pos: 0x202c
    type: s4
    doc: |-
      String ID 0x6EE:
       The footprint is [kind:]'s!
      The footprint is [kind:]'s![W:60]
  string_id_sentry_come_in_6ef:
    pos: 0x2030
    type: s4
    doc: |-
      String ID 0x6EF:
       Heard ya! Come in, visitor![W:30]
  string_id_sentry_wrong:
    pos: 0x2038
    type: s4
    doc: |-
      String ID 0x6F1:
       ......[se_play:0][W:30]Huh?! Looks wrong to me![W:50]
  string_id_sentry_buck_up:
    pos: 0x203c
    type: s4
    doc: |-
      String ID 0x6F2 (and also used as Loudred's speaker ID after subtracting 0x5B0):
       The correct answer is
      [kind:]! Buck up! And snap to it![se_play:0][W:120]
  string_id_sentry_footprint_is_6ec:
    pos: 0x2044
    type: s4
    doc: |-
      String ID 0x6EC:
       The footprint is [kind:]'s!
      The footprint is [kind:]'s![W:60]
  string_id_sentry_come_in_6ed:
    pos: 0x2048
    type: s4
    doc: |-
      String ID 0x6ED:
       Heard ya! Come in, visitor![W:30]
  string_id_sentry_keep_you_waiting:
    pos: 0x2050
    type: s4
    doc: |-
      String ID 0x6F3:
       [se_play:0]Sorry to keep you waiting.
  string_id_sentry_thatll_do_it:
    pos: 0x2054
    type: s4
    doc: |-
      String ID 0x6F4:
       [partner] and [hero]![C]
       That'll do it! Now get back here!
  sentry_chatot_monster_id:
    pos: 0x2058
    type: monster_id
    doc: Monster ID for Chatot, used as the speaker ID for dialogue.
  string_id_sentry_no_more_visitors:
    pos: 0x205c
    type: s4
    doc: |-
      String ID 0x6F5:
       [se_play:0]No more visitors! No more
      visitors! ♪
  string_id_sentry_thats_all:
    pos: 0x2060
    type: s4
    doc: |-
      String ID 0x6F6:
       OK, got that![C]
       Hey, [partner] and
      [hero]![C]
       That's all for today! Now get
      back here!
  sentry_grovyle_monster_id:
    pos: 0x2924
    type: monster_id
    doc: Monster ID for Grovyle, which appears to be explicitly excluded when 
      generating species choices.
  sentry_debug_menu_items:
    pos: 0x3960
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
