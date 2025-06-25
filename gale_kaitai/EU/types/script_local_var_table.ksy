doc: Represents a struct or union script_local_var_table defined within 
  pmdsky-debug.
meta:
  id: script_local_var_table
  endian: le
  bit-endian: le
  imports:
  - script_local_var_table_vars_array
seq:
- id: vars
  type: script_local_var_table_vars_array
