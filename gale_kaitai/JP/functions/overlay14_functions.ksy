doc: List of functions within OVERLAY14 with relative address locations as their
  values.
meta:
  id: overlay14_functions
  endian: le
instances:
  sentry_setup_state:
    value: 0x0
    doc: |-
      Allocates and initializes the sentry duty struct.

      Possibly the entrypoint of this overlay?

      r0: controls initial game state? If 2, the minigame starts in state 4 rather than state 6.
      return: always 1
  sentry_update_display:
    value: 0xcc0
    doc: |-
      Seems to update various parts of the display, such as the round number.

      No params.
  sentry_set_exiting_state:
    value: 0x159c
    doc: |-
      Sets the completion state to exiting, triggering the minigame to run its exit sequence.

      No params.
  sentry_run_state:
    value: 0x16c0
    doc: |-
      Run the minigame according to the current game state, or handle the transition to a new state if one has been set.

      The game is implemented using the state machine programming pattern. This function appears to contain the top-level code for running a single "turn" of the state machine, although presumably there's a higher level game engine that's calling this function in a loop somewhere.

      return: return code for the engine driving the minigame? Seems like 1 to keep going and 4 to stop
  sentry_set_state_intermediate:
    value: 0x2090
    doc: |-
      Queues up a new intermediate game state to transition to, where the transition handler will be called immediately by SentryRunState after the current state handler has returned.

      r0: new state
  sentry_state0:
    value: 0x20b0
    doc: No params.
  sentry_state1:
    value: 0x20d4
    doc: No params.
  sentry_state2:
    value: 0x212c
    doc: No params.
  sentry_state3:
    value: 0x2150
    doc: No params.
  sentry_state4:
    value: 0x2278
    doc: No params.
  sentry_state_exit:
    value: 0x229c
    doc: |-
      State 0x5: Exit (wraps SentrySetExitingState).

      No params.
  sentry_state6:
    value: 0x22a8
    doc: No params.
  sentry_state7:
    value: 0x22cc
    doc: |-
      This state corresponds to when Loudred tells you the instructions for the minigame (STRING_ID_SENTRY_INSTRUCTIONS).

      No params.
  sentry_state8:
    value: 0x22e4
    doc: No params.
  sentry_state9:
    value: 0x2308
    doc: No params.
  sentry_state_a:
    value: 0x232c
    doc: |-
      This state corresponds to when Loudred alerts you that someone is coming (STRING_ID_SENTRY_HERE_COMES).

      No params.
  sentry_state_b:
    value: 0x2344
    doc: No params.
  sentry_state_generate_choices:
    value: 0x235c
    doc: |-
      State 0xC: Generate the four choices for a round.

      No params.
  sentry_state_get_user_choice:
    value: 0x295c
    doc: |-
      State 0xD: Wait for the player to select an answer.

      No params.
  sentry_state_finalize_round:
    value: 0x2e8c
    doc: |-
      State 0xE: Deal with the bookkeeping after the player has made a final choice for the round.

      This includes things like incrementing the round counter. It also appears to check the final point count on the last round to determine the player's overall performance.

      No params.
  sentry_state_f:
    value: 0x31d0
    doc: No params.
  sentry_state10:
    value: 0x31e8
    doc: No params.
  sentry_state11:
    value: 0x3260
    doc: |-
      This state corresponds to when the partner tells you to try again after the player makes a wrong selection for the first time (STRING_ID_SENTRY_TRY_AGAIN).

      No params.
  sentry_state12:
    value: 0x3278
    doc: No params.
  sentry_state13:
    value: 0x32b0
    doc: |-
      This state corresponds to when Loudred tells you that you're out of time (STRING_ID_SENTRY_OUT_OF_TIME).

      No params.
  sentry_state14:
    value: 0x32d8
    doc: |-
      This state corresponds to when the player is shouting their guess (STRING_ID_SENTRY_FOOTPRINT_IS_6EE), and when Loudred tells the visitor to come in (STRING_ID_SENTRY_COME_IN_6EF).

      No params.
  sentry_state15:
    value: 0x32f0
    doc: No params.
  sentry_state16:
    value: 0x3330
    doc: No params.
  sentry_state17:
    value: 0x3388
    doc: |-
      This state corresponds to when Loudred tells the player that they chose the wrong answer (STRING_ID_SENTRY_WRONG, STRING_ID_SENTRY_BUCK_UP).

      No params.
  sentry_state18:
    value: 0x3400
    doc: No params.
  sentry_state19:
    value: 0x3438
    doc: |-
      This state seems to be similar to state 0x14, when the player is shouting their guess (STRING_ID_SENTRY_FOOTPRINT_IS_6EC), and when Loudred tells the visitor to come in (STRING_ID_SENTRY_COME_IN_6ED), but used in a different context (different state transitions to and from this state).

      No params.
  sentry_state1_a:
    value: 0x3450
    doc: No params.
  sentry_state_finalize_points:
    value: 0x3490
    doc: |-
      State 0x1B: Apply any modifiers to the player's point total, such as granting 2000 bonus points for 100% correctness.

      No params.
  sentry_state1_c:
    value: 0x3520
    doc: |-
      This state corresponds to when Loudred tells the player that they chose the correct answer ("Yep! Looks like you're right!").

      No params.
  sentry_state1_d:
    value: 0x3564
    doc: No params.
  sentry_state1_e:
    value: 0x35c8
    doc: |-
      This state corresponds to one of the possible dialogue options when you've finished all the rounds (STRING_ID_SENTRY_KEEP_YOU_WAITING, STRING_ID_SENTRY_THATLL_DO_IT).

      No params.
  sentry_state1_f:
    value: 0x35e0
    doc: No params.
  sentry_state20:
    value: 0x365c
    doc: |-
      This state corresponds to one of the possible dialogue options when you've finished all the rounds (STRING_ID_SENTRY_NO_MORE_VISITORS, STRING_ID_SENTRY_THATS_ALL).

      No params.
  sentry_state21:
    value: 0x3674
    doc: No params.
