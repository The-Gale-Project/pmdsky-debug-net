doc: Holds the data for the enum mission_subtype_outlaw.
meta:
  id: mission_subtype_outlaw
  endian: le
  bit-endian: le
seq:
- id: mission_subtype_outlaw_value
  type: b32
  enum: mission_subtype_outlaw_enum
enums:
  mission_subtype_outlaw_enum:
    0: mission_outlaw_normal_0
    1: mission_outlaw_normal_1
    2: mission_outlaw_normal_2
    3: mission_outlaw_normal_3
    4: mission_outlaw_escort
    5: mission_outlaw_fleeing
    6: mission_outlaw_hideout
    7: mission_outlaw_monster_house
