doc: Represents an array dungeon_tile_ptrs defined within pmdsky.
meta:
  id: dungeon_tile_ptrs_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: dungeon_tile_ptrs_array_dim_1
types:
  dungeon_tile_ptrs_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 56
  dungeon_tile_ptrs_array_dim_1:
    seq:
    - id: entries
      type: dungeon_tile_ptrs_array_dim_0
      repeat: expr
      repeat-expr: 32
