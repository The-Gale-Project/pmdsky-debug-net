doc: Represents an array OFFENSIVE_STAT_STAGE_MULTIPLIERS defined within pmdsky.
meta:
  id: offensive_stat_stage_multipliers_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: offensive_stat_stage_multipliers_array_dim_0
types:
  offensive_stat_stage_multipliers_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 21
