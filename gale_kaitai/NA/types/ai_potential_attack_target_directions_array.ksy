doc: Represents an array AI_POTENTIAL_ATTACK_TARGET_DIRECTIONS defined within 
  pmdsky.
meta:
  id: ai_potential_attack_target_directions_array
  endian: le
  bit-endian: le
  imports:
  - direction_id_8
seq:
- id: entries
  type: ai_potential_attack_target_directions_array_dim_0
types:
  ai_potential_attack_target_directions_array_dim_0:
    seq:
    - id: entries
      type: direction_id_8
      repeat: expr
      repeat-expr: 8
