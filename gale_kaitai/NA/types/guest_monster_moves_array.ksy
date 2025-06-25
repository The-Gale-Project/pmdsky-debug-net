doc: Represents an array guest_monster_moves defined within pmdsky.
meta:
  id: guest_monster_moves_array
  endian: le
  bit-endian: le
  imports:
  - move_id_16
seq:
- id: entries
  type: guest_monster_moves_array_dim_0
types:
  guest_monster_moves_array_dim_0:
    seq:
    - id: entries
      type: move_id_16
      repeat: expr
      repeat-expr: 4
