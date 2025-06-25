doc: Represents an array AI_REGULAR_ATTACK_WEIGHTS defined within pmdsky.
meta:
  id: ai_regular_attack_weights_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: ai_regular_attack_weights_array_dim_0
types:
  ai_regular_attack_weights_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 5
