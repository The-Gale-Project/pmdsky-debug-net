doc: Represents an array CORNER_CARDINAL_NEIGHBOR_IS_OPEN defined within pmdsky.
meta:
  id: corner_cardinal_neighbor_is_open_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: corner_cardinal_neighbor_is_open_array_dim_1
types:
  corner_cardinal_neighbor_is_open_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 8
  corner_cardinal_neighbor_is_open_array_dim_1:
    seq:
    - id: entries
      type: corner_cardinal_neighbor_is_open_array_dim_0
      repeat: expr
      repeat-expr: 4
