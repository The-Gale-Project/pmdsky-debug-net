doc: Represents an array SPECIAL_MONSTER_MOVE_ANIMATION_INFO defined within 
  pmdsky.
meta:
  id: special_monster_move_animation_info_array
  endian: le
  bit-endian: le
  imports:
  - special_monster_move_animation
seq:
- id: entries
  type: special_monster_move_animation_info_array_dim_0
types:
  special_monster_move_animation_info_array_dim_0:
    seq:
    - id: entries
      type: special_monster_move_animation
      repeat: expr
      repeat-expr: 7422
