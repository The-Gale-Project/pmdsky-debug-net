doc: Represents an array sentry_duty_field_0x3544 defined within pmdsky.
meta:
  id: sentry_duty_field_0x3544_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: sentry_duty_field_0x3544_array_dim_0
types:
  sentry_duty_field_0x3544_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 4
