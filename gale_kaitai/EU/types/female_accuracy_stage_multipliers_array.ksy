doc: Represents an array FEMALE_ACCURACY_STAGE_MULTIPLIERS defined within 
  pmdsky.
meta:
  id: female_accuracy_stage_multipliers_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: female_accuracy_stage_multipliers_array_dim_0
types:
  female_accuracy_stage_multipliers_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 21
