doc: Represents an array DEFENSIVE_STAT_STAGE_MULTIPLIERS defined within pmdsky.
meta:
  id: defensive_stat_stage_multipliers_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: defensive_stat_stage_multipliers_array_dim_0
types:
  defensive_stat_stage_multipliers_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 21
