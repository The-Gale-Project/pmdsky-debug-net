doc: Holds the data for the enum sentry_control_state.
meta:
  id: sentry_control_state
  endian: le
  bit-endian: le
seq:
- id: sentry_control_state_value
  type: b32
  enum: sentry_control_state_enum
enums:
  sentry_control_state_enum:
    0: sentry_ctrl_continue
    1: sentry_ctrl_state_transition
    2: sentry_ctrl_post_transition
    3: sentry_ctrl_intermediate_transition
