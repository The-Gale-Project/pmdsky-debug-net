doc: Represents an array sentry_duty_field_0x1bec defined within pmdsky.
meta:
  id: sentry_duty_field_0x1bec_array
  endian: le
  bit-endian: le
  imports:
  - animation
seq:
- id: entries
  type: sentry_duty_field_0x1bec_array_dim_0
types:
  sentry_duty_field_0x1bec_array_dim_0:
    seq:
    - id: entries
      type: animation
      repeat: expr
      repeat-expr: 16
