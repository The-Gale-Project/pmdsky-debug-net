doc: Represents an array enemy_spawn_stats_moves defined within pmdsky.
meta:
  id: enemy_spawn_stats_moves_array
  endian: le
  bit-endian: le
  imports:
  - move_id_16
seq:
- id: entries
  type: enemy_spawn_stats_moves_array_dim_0
types:
  enemy_spawn_stats_moves_array_dim_0:
    seq:
    - id: entries
      type: move_id_16
      repeat: expr
      repeat-expr: 4
