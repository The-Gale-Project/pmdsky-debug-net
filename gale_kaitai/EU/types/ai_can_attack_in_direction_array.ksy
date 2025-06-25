doc: Represents an array AI_CAN_ATTACK_IN_DIRECTION defined within pmdsky.
meta:
  id: ai_can_attack_in_direction_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: ai_can_attack_in_direction_array_dim_0
types:
  ai_can_attack_in_direction_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 8
