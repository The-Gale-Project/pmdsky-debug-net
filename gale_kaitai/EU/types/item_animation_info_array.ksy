doc: Represents an array ITEM_ANIMATION_INFO defined within pmdsky.
meta:
  id: item_animation_info_array
  endian: le
  bit-endian: le
  imports:
  - item_animation
seq:
- id: entries
  type: item_animation_info_array_dim_0
types:
  item_animation_info_array_dim_0:
    seq:
    - id: entries
      type: item_animation
      repeat: expr
      repeat-expr: 1400
