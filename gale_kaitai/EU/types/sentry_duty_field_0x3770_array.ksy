doc: Represents an array sentry_duty_field_0x3770 defined within pmdsky.
meta:
  id: sentry_duty_field_0x3770_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: sentry_duty_field_0x3770_array_dim_0
types:
  sentry_duty_field_0x3770_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 256
