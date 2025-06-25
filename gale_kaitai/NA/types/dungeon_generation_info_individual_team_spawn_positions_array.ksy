doc: Represents an array dungeon_generation_info_individual_team_spawn_positions
  defined within pmdsky.
meta:
  id: dungeon_generation_info_individual_team_spawn_positions_array
  endian: le
  bit-endian: le
  imports:
  - position
seq:
- id: entries
  type: dungeon_generation_info_individual_team_spawn_positions_array_dim_0
types:
  dungeon_generation_info_individual_team_spawn_positions_array_dim_0:
    seq:
    - id: entries
      type: position
      repeat: expr
      repeat-expr: 4
