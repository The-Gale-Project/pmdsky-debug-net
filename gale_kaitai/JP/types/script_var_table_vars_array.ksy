doc: Represents an array script_var_table_vars defined within pmdsky.
meta:
  id: script_var_table_vars_array
  endian: le
  bit-endian: le
  imports:
  - script_var
seq:
- id: entries
  type: script_var_table_vars_array_dim_0
types:
  script_var_table_vars_array_dim_0:
    seq:
    - id: entries
      type: script_var
      repeat: expr
      repeat-expr: 115
