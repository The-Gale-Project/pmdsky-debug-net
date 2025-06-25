doc: Represents an array team_member_defensive_stats defined within pmdsky.
meta:
  id: team_member_defensive_stats_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: team_member_defensive_stats_array_dim_0
types:
  team_member_defensive_stats_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 2
