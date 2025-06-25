doc: Represents an array DISPLACEMENTS_WITHIN_2_LARGEST_FIRST defined within 
  pmdsky.
meta:
  id: displacements_within_2_largest_first_array
  endian: le
  bit-endian: le
  imports:
  - position
seq:
- id: entries
  type: displacements_within_2_largest_first_array_dim_0
types:
  displacements_within_2_largest_first_array_dim_0:
    seq:
    - id: entries
      type: position
      repeat: expr
      repeat-expr: 26
