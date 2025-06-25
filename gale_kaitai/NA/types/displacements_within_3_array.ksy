doc: Represents an array DISPLACEMENTS_WITHIN_3 defined within pmdsky.
meta:
  id: displacements_within_3_array
  endian: le
  bit-endian: le
  imports:
  - position
seq:
- id: entries
  type: displacements_within_3_array_dim_0
types:
  displacements_within_3_array_dim_0:
    seq:
    - id: entries
      type: position
      repeat: expr
      repeat-expr: 50
