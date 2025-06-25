doc: Represents an array dungeon_monster_unique_id defined within pmdsky.
meta:
  id: dungeon_monster_unique_id_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_monster_unique_id_array_dim_0
types:
  dungeon_monster_unique_id_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 20
