doc: Represents an array dungeon_fixed_room_tiles defined within pmdsky.
meta:
  id: dungeon_fixed_room_tiles_array
  endian: le
  bit-endian: le
  imports:
  - tile
seq:
- id: entries
  type: dungeon_fixed_room_tiles_array_dim_1
types:
  dungeon_fixed_room_tiles_array_dim_0:
    seq:
    - id: entries
      type: tile
      repeat: expr
      repeat-expr: 8
  dungeon_fixed_room_tiles_array_dim_1:
    seq:
    - id: entries
      type: dungeon_fixed_room_tiles_array_dim_0
      repeat: expr
      repeat-expr: 8
