doc: Represents an array preprocessor_args_number_vals defined within pmdsky.
meta:
  id: preprocessor_args_number_vals_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: preprocessor_args_number_vals_array_dim_0
types:
  preprocessor_args_number_vals_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 5
