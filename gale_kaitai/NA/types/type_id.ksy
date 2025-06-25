doc: Holds the data for the enum type_id.
meta:
  id: type_id
  endian: le
  bit-endian: le
seq:
- id: type_id_value
  type: b32
  enum: type_id_enum
enums:
  type_id_enum:
    0: type_none
    1: type_normal
    2: type_fire
    3: type_water
    4: type_grass
    5: type_electric
    6: type_ice
    7: type_fighting
    8: type_poison
    9: type_ground
    10: type_flying
    11: type_psychic
    12: type_bug
    13: type_rock
    14: type_ghost
    15: type_dragon
    16: type_dark
    17: type_steel
    18: type_neutral
