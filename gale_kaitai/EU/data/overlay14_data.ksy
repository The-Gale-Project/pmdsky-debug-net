meta:
  id: overlay14_data
  endian: le
  imports:
  - ../types/sentry_debug_menu_items_array
  - ../types/pointer
  - ../types/sentry_duty_state_handler_table_array
instances:
  sentry_debug_menu_items:
    pos: 0x39c0
    type: sentry_debug_menu_items_array
    doc: This symbol is missing documentation.
  sentry_duty_ptr:
    pos: 0x3aa0
    type: pointer
    doc: Pointer to the SENTRY_DUTY_STRUCT.
  sentry_duty_state_handler_table:
    pos: 0x3ab4
    type: sentry_duty_state_handler_table_array
    doc: |-
      Null-terminated table of handler functions for the different states in the state machine. See SentryRunState.

      type: state_handler_fn_t[35]
