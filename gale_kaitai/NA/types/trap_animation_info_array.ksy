doc: Represents an array TRAP_ANIMATION_INFO defined within pmdsky.
meta:
  id: trap_animation_info_array
  endian: le
  bit-endian: le
  imports:
  - trap_animation
seq:
- id: entries
  type: trap_animation_info_array_dim_0
types:
  trap_animation_info_array_dim_0:
    seq:
    - id: entries
      type: trap_animation
      repeat: expr
      repeat-expr: 26
