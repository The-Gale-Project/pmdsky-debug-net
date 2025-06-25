doc: Represents an array KAOMADO_FILEPATH defined within pmdsky.
meta:
  id: kaomado_filepath_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: kaomado_filepath_array_dim_0
types:
  kaomado_filepath_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 20
