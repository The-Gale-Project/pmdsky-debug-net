doc: Represents an array dungeon_spawn_entries defined within pmdsky.
meta:
  id: dungeon_spawn_entries_array
  endian: le
  bit-endian: le
  imports:
  - monster_spawn_entry
seq:
- id: entries
  type: dungeon_spawn_entries_array_dim_0
types:
  dungeon_spawn_entries_array_dim_0:
    seq:
    - id: entries
      type: monster_spawn_entry
      repeat: expr
      repeat-expr: 16
