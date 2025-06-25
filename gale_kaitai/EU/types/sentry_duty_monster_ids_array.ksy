doc: Represents an array SENTRY_DUTY_MONSTER_IDS defined within pmdsky.
meta:
  id: sentry_duty_monster_ids_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: sentry_duty_monster_ids_array_dim_0
types:
  sentry_duty_monster_ids_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 102
