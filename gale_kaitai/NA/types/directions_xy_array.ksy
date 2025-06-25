doc: Represents an array DIRECTIONS_XY defined within pmdsky.
meta:
  id: directions_xy_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: directions_xy_array_dim_1
types:
  directions_xy_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
  directions_xy_array_dim_1:
    seq:
    - id: entries
      type: directions_xy_array_dim_0
      repeat: expr
      repeat-expr: 8
