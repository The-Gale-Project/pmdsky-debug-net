doc: Represents an array action_data_action_parameters defined within pmdsky.
meta:
  id: action_data_action_parameters_array
  endian: le
  bit-endian: le
  imports:
  - action_parameter
seq:
- id: entries
  type: action_data_action_parameters_array_dim_0
types:
  action_data_action_parameters_array_dim_0:
    seq:
    - id: entries
      type: action_parameter
      repeat: expr
      repeat-expr: 2
