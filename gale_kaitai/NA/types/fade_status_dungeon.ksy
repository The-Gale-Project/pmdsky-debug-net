doc: Holds the data for the enum fade_status_dungeon.
meta:
  id: fade_status_dungeon
  endian: le
  bit-endian: le
seq:
- id: fade_status_dungeon_value
  type: b32
  enum: fade_status_dungeon_enum
enums:
  fade_status_dungeon_enum:
    0: dungeon_fade_0x0
    1: dungeon_fade_none
    2: dungeon_fade_in
    3: dungeon_fade_out
    4: dungeon_fade_0x4
    5: dungeon_fade_0x5
