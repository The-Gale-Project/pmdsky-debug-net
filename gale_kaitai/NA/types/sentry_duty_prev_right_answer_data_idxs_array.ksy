doc: Represents an array sentry_duty_prev_right_answer_data_idxs defined within 
  pmdsky.
meta:
  id: sentry_duty_prev_right_answer_data_idxs_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: sentry_duty_prev_right_answer_data_idxs_array_dim_0
types:
  sentry_duty_prev_right_answer_data_idxs_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 6
