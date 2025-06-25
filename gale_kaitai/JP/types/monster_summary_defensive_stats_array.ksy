doc: Represents an array monster_summary_defensive_stats defined within pmdsky.
meta:
  id: monster_summary_defensive_stats_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: monster_summary_defensive_stats_array_dim_0
types:
  monster_summary_defensive_stats_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 2
