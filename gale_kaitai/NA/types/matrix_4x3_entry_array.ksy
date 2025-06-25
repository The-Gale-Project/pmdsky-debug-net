doc: Represents an array matrix_4x3_entry defined within pmdsky.
meta:
  id: matrix_4x3_entry_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: matrix_4x3_entry_array_dim_1
types:
  matrix_4x3_entry_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 3
  matrix_4x3_entry_array_dim_1:
    seq:
    - id: entries
      type: matrix_4x3_entry_array_dim_0
      repeat: expr
      repeat-expr: 4
