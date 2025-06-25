doc: Holds the data for the enum dungeon_objective.
meta:
  id: dungeon_objective
  endian: le
  bit-endian: le
seq:
- id: dungeon_objective_value
  type: b32
  enum: dungeon_objective_enum
enums:
  dungeon_objective_enum:
    0: objective_story
    1: objective_normal
    2: objective_rescue
    3: objective_unk_game_mode_5
