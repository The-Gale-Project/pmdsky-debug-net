doc: Holds the data for the enum mission_subtype_challenge.
meta:
  id: mission_subtype_challenge
  endian: le
  bit-endian: le
seq:
- id: mission_subtype_challenge_value
  type: b32
  enum: mission_subtype_challenge_enum
enums:
  mission_subtype_challenge_enum:
    0: mission_challenge_normal
    1: mission_challenge_mewtwo
    2: mission_challenge_entei
    3: mission_challenge_raikou
    4: mission_challenge_suicune
    5: mission_challenge_jirachi
