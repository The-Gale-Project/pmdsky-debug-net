doc: Holds the data for the enum mission_template_dungeon_case.
meta:
  id: mission_template_dungeon_case
  endian: le
  bit-endian: le
seq:
- id: mission_template_dungeon_case_value
  type: b32
  enum: mission_template_dungeon_case_enum
enums:
  mission_template_dungeon_case_enum:
    0: dungeon_case_specific_opened
    1: dungeon_case_specific_closed
    2: dungeon_case_unk_2
    3: dungeon_case_unk_3
    4: dungeon_case_random_open
    5: dungeon_case_random_closed
