doc: Holds the data for the enum mission_restriction_type.
meta:
  id: mission_restriction_type
  endian: le
  bit-endian: le
seq:
- id: mission_restriction_type_value
  type: b32
  enum: mission_restriction_type_enum
enums:
  mission_restriction_type_enum:
    0: mission_restriction_none
    1: mission_restriction_type
    2: mission_restriction_monster
