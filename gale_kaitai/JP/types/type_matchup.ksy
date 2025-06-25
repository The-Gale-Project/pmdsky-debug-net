doc: Holds the data for the enum type_matchup.
meta:
  id: type_matchup
  endian: le
  bit-endian: le
seq:
- id: type_matchup_value
  type: b32
  enum: type_matchup_enum
enums:
  type_matchup_enum:
    0: matchup_immune
    1: matchup_not_very_effective
    2: matchup_neutral
    3: matchup_super_effective
