doc: Represents an array preprocessor_args_strings defined within pmdsky.
meta:
  id: preprocessor_args_strings_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: preprocessor_args_strings_array_dim_0
types:
  preprocessor_args_strings_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 5
