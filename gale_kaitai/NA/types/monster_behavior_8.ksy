doc: Holds bitsized data for the parent enum monster_behavior.
meta:
  id: monster_behavior_8
  endian: le
  bit-endian: le
seq:
- id: monster_behavior_8_value
  type: b8
  enum: monster_behavior_8_enum
enums:
  monster_behavior_8_enum:
    0: behavior_normal_enemy_0x0
    1: behavior_outlaw
    2: behavior_hidden_outlaw
    3: behavior_fleeing_outlaw
    4: behavior_outlaw_team_leader
    5: behavior_outlaw_team_minion
    6: behavior_fixed_enemy
    7: behavior_rescue_target
    8: behavior_wandering_enemy_0x8
    9: behavior_normal_enemy_0x9
    10: behavior_ally
    11: behavior_explorer_maze_1
    12: behavior_explorer_maze_2
    13: behavior_explorer_maze_3
    14: behavior_explorer_maze_4
    15: behavior_invalid
    16: behavior_secret_bazaar_kirlia
    17: behavior_secret_bazaar_mime_jr
    18: behavior_secret_bazaar_swalot
    19: behavior_secret_bazaar_lickilicky
    20: behavior_secret_bazaar_shedinja
    21: behavior_wandering_enemy_0x15
