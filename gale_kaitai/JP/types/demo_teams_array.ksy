doc: Represents an array DEMO_TEAMS defined within pmdsky.
meta:
  id: demo_teams_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: demo_teams_array_dim_1
types:
  demo_teams_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 2
  demo_teams_array_dim_1:
    seq:
    - id: entries
      type: demo_teams_array_dim_0
      repeat: expr
      repeat-expr: 18
