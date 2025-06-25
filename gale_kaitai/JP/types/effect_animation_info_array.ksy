doc: Represents an array EFFECT_ANIMATION_INFO defined within pmdsky.
meta:
  id: effect_animation_info_array
  endian: le
  bit-endian: le
  imports:
  - effect_animation
seq:
- id: entries
  type: effect_animation_info_array_dim_0
types:
  effect_animation_info_array_dim_0:
    seq:
    - id: entries
      type: effect_animation
      repeat: expr
      repeat-expr: 700
