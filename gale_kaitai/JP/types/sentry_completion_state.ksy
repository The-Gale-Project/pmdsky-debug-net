doc: Holds the data for the enum sentry_completion_state.
meta:
  id: sentry_completion_state
  endian: le
  bit-endian: le
seq:
- id: sentry_completion_state_value
  type: b32
  enum: sentry_completion_state_enum
enums:
  sentry_completion_state_enum:
    0: sentry_completion_in_progress
    1: sentry_completion_exiting
    2: sentry_completion_finalizing
    3: sentry_completion_done
