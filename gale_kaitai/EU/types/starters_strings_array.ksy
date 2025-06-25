doc: Represents an array STARTERS_STRINGS defined within pmdsky.
meta:
  id: starters_strings_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: starters_strings_array_dim_0
types:
  starters_strings_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 48
