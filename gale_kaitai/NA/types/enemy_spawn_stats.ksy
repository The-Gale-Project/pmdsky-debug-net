doc: Represents a struct or union enemy_spawn_stats defined within pmdsky-debug.
meta:
  id: enemy_spawn_stats
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
  - enemy_spawn_stats_moves_array
seq:
- id: id
  type: monster_id_16
- id: level
  type: u2
- id: moves
  type: enemy_spawn_stats_moves_array
- id: max_hp
  type: u2
- id: atk
  type: u1
- id: def
  type: u1
- id: sp_atk
  type: u1
- id: sp_def
  type: u1
