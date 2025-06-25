doc: Holds bitsized data for the parent enum mission_subtype_explore.
meta:
  id: mission_subtype_explore_8
  endian: le
  bit-endian: le
seq:
- id: mission_subtype_explore_8_value
  type: b8
  enum: mission_subtype_explore_8_enum
enums:
  mission_subtype_explore_8_enum:
    0: mission_explore_normal
    1: mission_explore_sealed_chamber
    2: mission_explore_golden_chamber
    3: mission_explore_new_dungeon
