doc: Represents an array SCRIPT_COMMAND_PARSING_DATA defined within pmdsky.
meta:
  id: script_command_parsing_data_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: script_command_parsing_data_array_dim_0
types:
  script_command_parsing_data_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 32
