doc: Represents an array script_opcode_table_ops defined within pmdsky.
meta:
  id: script_opcode_table_ops_array
  endian: le
  bit-endian: le
  imports:
  - script_opcode
seq:
- id: entries
  type: script_opcode_table_ops_array_dim_0
types:
  script_opcode_table_ops_array_dim_0:
    seq:
    - id: entries
      type: script_opcode
      repeat: expr
      repeat-expr: 383
