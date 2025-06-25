doc: Represents an array sentry_duty_choices defined within pmdsky.
meta:
  id: sentry_duty_choices_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: sentry_duty_choices_array_dim_0
types:
  sentry_duty_choices_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 4
