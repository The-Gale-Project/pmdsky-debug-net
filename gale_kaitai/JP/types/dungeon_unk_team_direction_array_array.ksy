doc: Represents an array dungeon_unk_team_direction_array defined within pmdsky.
meta:
  id: dungeon_unk_team_direction_array_array
  endian: le
  bit-endian: le
  imports:
  - direction_id_8
seq:
- id: entries
  type: dungeon_unk_team_direction_array_array_dim_0
types:
  dungeon_unk_team_direction_array_array_dim_0:
    seq:
    - id: entries
      type: direction_id_8
      repeat: expr
      repeat-expr: 8
