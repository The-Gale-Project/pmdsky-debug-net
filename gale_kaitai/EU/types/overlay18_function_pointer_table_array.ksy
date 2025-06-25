doc: Represents an array OVERLAY18_FUNCTION_POINTER_TABLE defined within pmdsky.
meta:
  id: overlay18_function_pointer_table_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: overlay18_function_pointer_table_array_dim_0
types:
  overlay18_function_pointer_table_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 76
