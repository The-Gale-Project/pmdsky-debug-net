doc: Represents an array sentry_duty_field_0x282c defined within pmdsky.
meta:
  id: sentry_duty_field_0x282c_array
  endian: le
  bit-endian: le
  imports:
  - animation
seq:
- id: entries
  type: sentry_duty_field_0x282c_array_dim_0
types:
  sentry_duty_field_0x282c_array_dim_0:
    seq:
    - id: entries
      type: animation
      repeat: expr
      repeat-expr: 2
