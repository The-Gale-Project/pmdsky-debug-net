doc: Represents an array UNOWN_SPECIES_ADDITIONAL_CHARS defined within pmdsky.
meta:
  id: unown_species_additional_chars_array
  endian: le
  bit-endian: le
  imports:
  - monster_id
seq:
- id: entries
  type: unown_species_additional_chars_array_dim_0
types:
  unown_species_additional_chars_array_dim_0:
    seq:
    - id: entries
      type: monster_id
      repeat: expr
      repeat-expr: 28
