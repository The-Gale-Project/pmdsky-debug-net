doc: Represents an array team_member_moves defined within pmdsky.
meta:
  id: team_member_moves_array
  endian: le
  bit-endian: le
  imports:
  - move
seq:
- id: entries
  type: team_member_moves_array_dim_0
types:
  team_member_moves_array_dim_0:
    seq:
    - id: entries
      type: move
      repeat: expr
      repeat-expr: 4
