doc: Represents an array PERISH_SONG_TURN_RANGE defined within pmdsky.
meta:
  id: perish_song_turn_range_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: perish_song_turn_range_array_dim_0
types:
  perish_song_turn_range_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
