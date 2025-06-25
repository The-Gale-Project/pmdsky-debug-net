doc: Represents an array QUIZ_ANSWER_POINTS defined within pmdsky.
meta:
  id: quiz_answer_points_array
  endian: le
  bit-endian: le
  imports:
  - quiz_answer_points_entry
seq:
- id: entries
  type: quiz_answer_points_array_dim_0
types:
  quiz_answer_points_array_dim_0:
    seq:
    - id: entries
      type: quiz_answer_points_entry
      repeat: expr
      repeat-expr: 174
