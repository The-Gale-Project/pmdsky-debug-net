doc: Represents an array statuses_original_types defined within pmdsky.
meta:
  id: statuses_original_types_array
  endian: le
  bit-endian: le
  imports:
  - type_id_8
seq:
- id: entries
  type: statuses_original_types_array_dim_0
types:
  statuses_original_types_array_dim_0:
    seq:
    - id: entries
      type: type_id_8
      repeat: expr
      repeat-expr: 2
