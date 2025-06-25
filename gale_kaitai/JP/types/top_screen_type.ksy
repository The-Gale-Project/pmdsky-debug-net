doc: Holds the data for the enum top_screen_type.
meta:
  id: top_screen_type
  endian: le
  bit-endian: le
seq:
- id: top_screen_type_value
  type: b32
  enum: top_screen_type_enum
enums:
  top_screen_type_enum:
    0: top_screen_type_text_log
    1: top_screen_type_team_stats
    2: top_screen_type_controls
    3: top_screen_type_map_and_team
    4: top_screen_type_job
