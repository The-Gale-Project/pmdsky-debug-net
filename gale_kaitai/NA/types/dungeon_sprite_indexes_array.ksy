doc: Represents an array dungeon_sprite_indexes defined within pmdsky.
meta:
  id: dungeon_sprite_indexes_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: dungeon_sprite_indexes_array_dim_0
types:
  dungeon_sprite_indexes_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 1155
