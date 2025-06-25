doc: Represents an array dungeon_fainted_monster_offensive_stats defined within 
  pmdsky.
meta:
  id: dungeon_fainted_monster_offensive_stats_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_fainted_monster_offensive_stats_array_dim_0
types:
  dungeon_fainted_monster_offensive_stats_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 2
