doc: Represents an array ground_monster_defensive_stats defined within pmdsky.
meta:
  id: ground_monster_defensive_stats_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: ground_monster_defensive_stats_array_dim_0
types:
  ground_monster_defensive_stats_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 2
