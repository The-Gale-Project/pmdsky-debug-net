doc: Represents an array MUSIC_ID_TABLE defined within pmdsky.
meta:
  id: music_id_table_array
  endian: le
  bit-endian: le
  imports:
  - music_id_16
seq:
- id: entries
  type: music_id_table_array_dim_0
types:
  music_id_table_array_dim_0:
    seq:
    - id: entries
      type: music_id_16
      repeat: expr
      repeat-expr: 170
