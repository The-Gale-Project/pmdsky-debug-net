doc: Represents an array MISSION_RANK_POINTS defined within pmdsky.
meta:
  id: mission_rank_points_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: mission_rank_points_array_dim_0
types:
  mission_rank_points_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 16
