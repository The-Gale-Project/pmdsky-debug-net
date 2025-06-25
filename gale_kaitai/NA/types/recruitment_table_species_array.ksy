doc: Represents an array RECRUITMENT_TABLE_SPECIES defined within pmdsky.
meta:
  id: recruitment_table_species_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: recruitment_table_species_array_dim_0
types:
  recruitment_table_species_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 22
