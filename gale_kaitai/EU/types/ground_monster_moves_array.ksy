doc: Represents an array ground_monster_moves defined within pmdsky.
meta:
  id: ground_monster_moves_array
  endian: le
  bit-endian: le
  imports:
  - ground_move
seq:
- id: entries
  type: ground_monster_moves_array_dim_0
types:
  ground_monster_moves_array_dim_0:
    seq:
    - id: entries
      type: ground_move
      repeat: expr
      repeat-expr: 4
