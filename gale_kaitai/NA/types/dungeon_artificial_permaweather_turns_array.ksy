doc: Represents an array dungeon_artificial_permaweather_turns defined within 
  pmdsky.
meta:
  id: dungeon_artificial_permaweather_turns_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_artificial_permaweather_turns_array_dim_0
types:
  dungeon_artificial_permaweather_turns_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 8
