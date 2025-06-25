doc: Represents an array TACTIC_NAME_STRING_IDS defined within pmdsky.
meta:
  id: tactic_name_string_ids_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: tactic_name_string_ids_array_dim_0
types:
  tactic_name_string_ids_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 12
