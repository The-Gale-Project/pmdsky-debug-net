doc: Represents an array SCRIPT_OP_CODE_NAMES defined within pmdsky.
meta:
  id: script_op_code_names_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: script_op_code_names_array_dim_0
types:
  script_op_code_names_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 0
