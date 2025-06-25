doc: Represents an array QUIZ_ANSWER_STRINGS defined within pmdsky.
meta:
  id: quiz_answer_strings_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: quiz_answer_strings_array_dim_0
types:
  quiz_answer_strings_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 176
