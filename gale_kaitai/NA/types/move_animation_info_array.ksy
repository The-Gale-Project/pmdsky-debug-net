doc: Represents an array MOVE_ANIMATION_INFO defined within pmdsky.
meta:
  id: move_animation_info_array
  endian: le
  bit-endian: le
  imports:
  - move_animation
seq:
- id: entries
  type: move_animation_info_array_dim_0
types:
  move_animation_info_array_dim_0:
    seq:
    - id: entries
      type: move_animation
      repeat: expr
      repeat-expr: 563
