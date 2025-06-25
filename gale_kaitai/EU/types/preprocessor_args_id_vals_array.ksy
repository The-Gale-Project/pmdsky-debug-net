doc: Represents an array preprocessor_args_id_vals defined within pmdsky.
meta:
  id: preprocessor_args_id_vals_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: preprocessor_args_id_vals_array_dim_0
types:
  preprocessor_args_id_vals_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 5
