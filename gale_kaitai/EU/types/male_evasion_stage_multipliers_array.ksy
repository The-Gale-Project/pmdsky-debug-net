doc: Represents an array MALE_EVASION_STAGE_MULTIPLIERS defined within pmdsky.
meta:
  id: male_evasion_stage_multipliers_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: male_evasion_stage_multipliers_array_dim_0
types:
  male_evasion_stage_multipliers_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 21
