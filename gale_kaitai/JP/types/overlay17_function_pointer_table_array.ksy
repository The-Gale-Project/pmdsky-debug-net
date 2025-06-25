doc: Represents an array OVERLAY17_FUNCTION_POINTER_TABLE defined within pmdsky.
meta:
  id: overlay17_function_pointer_table_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: overlay17_function_pointer_table_array_dim_0
types:
  overlay17_function_pointer_table_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 42
