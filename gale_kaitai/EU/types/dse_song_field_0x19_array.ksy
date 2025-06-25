doc: Represents an array dse_song_field_0x19 defined within pmdsky.
meta:
  id: dse_song_field_0x19_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_song_field_0x19_array_dim_0
types:
  dse_song_field_0x19_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 19
