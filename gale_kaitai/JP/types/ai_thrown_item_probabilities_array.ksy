doc: Represents an array AI_THROWN_ITEM_PROBABILITIES defined within pmdsky.
meta:
  id: ai_thrown_item_probabilities_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: ai_thrown_item_probabilities_array_dim_0
types:
  ai_thrown_item_probabilities_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 8
