doc: Represents an array script_var_value_table_position_direction defined 
  within pmdsky.
meta:
  id: script_var_value_table_position_direction_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: script_var_value_table_position_direction_array_dim_0
types:
  script_var_value_table_position_direction_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 3
