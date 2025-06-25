doc: Represents an array MONSTER_TREATMENT_DATA defined within pmdsky.
meta:
  id: monster_treatment_data_array
  endian: le
  bit-endian: le
  imports:
  - monster_treatment
seq:
- id: entries
  type: monster_treatment_data_array_dim_3
types:
  monster_treatment_data_array_dim_0:
    seq:
    - id: entries
      type: monster_treatment
      repeat: expr
      repeat-expr: 2
  monster_treatment_data_array_dim_1:
    seq:
    - id: entries
      type: monster_treatment_data_array_dim_0
      repeat: expr
      repeat-expr: 2
  monster_treatment_data_array_dim_2:
    seq:
    - id: entries
      type: monster_treatment_data_array_dim_1
      repeat: expr
      repeat-expr: 2
  monster_treatment_data_array_dim_3:
    seq:
    - id: entries
      type: monster_treatment_data_array_dim_2
      repeat: expr
      repeat-expr: 4
