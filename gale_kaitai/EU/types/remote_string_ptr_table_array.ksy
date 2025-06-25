doc: Represents an array REMOTE_STRING_PTR_TABLE defined within pmdsky.
meta:
  id: remote_string_ptr_table_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: remote_string_ptr_table_array_dim_0
types:
  remote_string_ptr_table_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 7
