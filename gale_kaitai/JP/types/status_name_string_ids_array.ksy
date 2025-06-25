doc: Represents an array STATUS_NAME_STRING_IDS defined within pmdsky.
meta:
  id: status_name_string_ids_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: status_name_string_ids_array_dim_0
types:
  status_name_string_ids_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 102
