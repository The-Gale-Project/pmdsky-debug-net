doc: Represents an array MISSION_FLOOR_RANKS_PTRS defined within pmdsky.
meta:
  id: mission_floor_ranks_ptrs_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: mission_floor_ranks_ptrs_array_dim_0
types:
  mission_floor_ranks_ptrs_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 100
