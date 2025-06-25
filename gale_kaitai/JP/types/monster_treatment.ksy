doc: Holds the data for the enum monster_treatment.
meta:
  id: monster_treatment
  endian: le
  bit-endian: le
seq:
- id: monster_treatment_value
  type: b32
  enum: monster_treatment_enum
enums:
  monster_treatment_enum:
    0: treatment_treat_as_ally
    1: treatment_treat_as_enemy
    2: treatment_ignore
