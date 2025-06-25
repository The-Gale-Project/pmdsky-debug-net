doc: Represents an array STATUSES_FULL_DESCRIPTION_STRING_IDS defined within 
  pmdsky.
meta:
  id: statuses_full_description_string_ids_array
  endian: le
  bit-endian: le
  imports:
  - status_description
seq:
- id: entries
  type: statuses_full_description_string_ids_array_dim_0
types:
  statuses_full_description_string_ids_array_dim_0:
    seq:
    - id: entries
      type: status_description
      repeat: expr
      repeat-expr: 103
