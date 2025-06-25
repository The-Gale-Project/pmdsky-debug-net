doc: Represents an array MUSIC_DURATION_LOOKUP_TABLE_1 defined within pmdsky.
meta:
  id: music_duration_lookup_table_1_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: music_duration_lookup_table_1_array_dim_0
types:
  music_duration_lookup_table_1_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 128
