doc: Represents an array AI_POTENTIAL_ATTACK_TARGETS defined within pmdsky.
meta:
  id: ai_potential_attack_targets_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: ai_potential_attack_targets_array_dim_0
types:
  ai_potential_attack_targets_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 8
