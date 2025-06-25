doc: Represents an array SENTRY_DUTY_STATE_HANDLER_TABLE defined within pmdsky.
meta:
  id: sentry_duty_state_handler_table_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: sentry_duty_state_handler_table_array_dim_0
types:
  sentry_duty_state_handler_table_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 35
