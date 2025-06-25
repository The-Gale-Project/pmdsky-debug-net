doc: Represents an array RANK_STRING_PTR_TABLE defined within pmdsky.
meta:
  id: rank_string_ptr_table_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: rank_string_ptr_table_array_dim_0
types:
  rank_string_ptr_table_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 16
