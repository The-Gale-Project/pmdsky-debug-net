doc: Holds the data for the enum team_id.
meta:
  id: team_id
  endian: le
  bit-endian: le
seq:
- id: team_id_value
  type: b32
  enum: team_id_enum
enums:
  team_id_enum:
    0: team_main
    1: team_special_episode
    2: team_rescue
