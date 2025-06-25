doc: Holds the data for the enum game_id.
meta:
  id: game_id
  endian: le
  bit-endian: le
seq:
- id: game_id_value
  type: b32
  enum: game_id_enum
enums:
  game_id_enum:
    0: game_sky
    1: game_time
    2: game_darkness
