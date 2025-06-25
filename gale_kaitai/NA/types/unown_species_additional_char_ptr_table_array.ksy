doc: Represents an array UNOWN_SPECIES_ADDITIONAL_CHAR_PTR_TABLE defined within 
  pmdsky.
meta:
  id: unown_species_additional_char_ptr_table_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: unown_species_additional_char_ptr_table_array_dim_0
types:
  unown_species_additional_char_ptr_table_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 28
