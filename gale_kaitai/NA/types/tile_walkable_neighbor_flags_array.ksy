doc: Represents an array tile_walkable_neighbor_flags defined within pmdsky.
meta:
  id: tile_walkable_neighbor_flags_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: tile_walkable_neighbor_flags_array_dim_0
types:
  tile_walkable_neighbor_flags_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 4
