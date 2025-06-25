doc: Represents an array script_var_value_table_scenario_select defined within 
  pmdsky.
meta:
  id: script_var_value_table_scenario_select_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: script_var_value_table_scenario_select_array_dim_0
types:
  script_var_value_table_scenario_select_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 2
