doc: Represents an array dungeon_monsters defined within pmdsky.
meta:
  id: dungeon_monsters_array
  endian: le
  bit-endian: le
  imports:
  - monster
seq:
- id: entries
  type: dungeon_monsters_array_dim_0
types:
  dungeon_monsters_array_dim_0:
    seq:
    - id: entries
      type: monster
      repeat: expr
      repeat-expr: 20
