doc: Represents an array dungeon_generation_info_tiles defined within pmdsky.
meta:
  id: dungeon_generation_info_tiles_array
  endian: le
  bit-endian: le
  imports:
  - tile
seq:
- id: entries
  type: dungeon_generation_info_tiles_array_dim_1
types:
  dungeon_generation_info_tiles_array_dim_0:
    seq:
    - id: entries
      type: tile
      repeat: expr
      repeat-expr: 56
  dungeon_generation_info_tiles_array_dim_1:
    seq:
    - id: entries
      type: dungeon_generation_info_tiles_array_dim_0
      repeat: expr
      repeat-expr: 32
