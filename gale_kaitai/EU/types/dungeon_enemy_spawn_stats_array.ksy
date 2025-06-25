doc: Represents an array dungeon_enemy_spawn_stats defined within pmdsky.
meta:
  id: dungeon_enemy_spawn_stats_array
  endian: le
  bit-endian: le
  imports:
  - enemy_spawn_stats
seq:
- id: entries
  type: dungeon_enemy_spawn_stats_array_dim_0
types:
  dungeon_enemy_spawn_stats_array_dim_0:
    seq:
    - id: entries
      type: enemy_spawn_stats
      repeat: expr
      repeat-expr: 64
