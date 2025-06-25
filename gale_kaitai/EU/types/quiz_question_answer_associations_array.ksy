doc: Represents an array QUIZ_QUESTION_ANSWER_ASSOCIATIONS defined within 
  pmdsky.
meta:
  id: quiz_question_answer_associations_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: quiz_question_answer_associations_array_dim_0
types:
  quiz_question_answer_associations_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 66
