doc: Represents an array monster_moves defined within pmdsky.
meta:
  id: monster_moves_array
  endian: le
  bit-endian: le
  imports:
  - move
seq:
- id: entries
  type: monster_moves_array_dim_0
types:
  monster_moves_array_dim_0:
    seq:
    - id: entries
      type: move
      repeat: expr
      repeat-expr: 4
