doc: Represents an array AI_POTENTIAL_ATTACK_TARGET_WEIGHTS defined within 
  pmdsky.
meta:
  id: ai_potential_attack_target_weights_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: ai_potential_attack_target_weights_array_dim_0
types:
  ai_potential_attack_target_weights_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 8
