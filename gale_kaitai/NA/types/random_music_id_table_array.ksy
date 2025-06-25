doc: Represents an array RANDOM_MUSIC_ID_TABLE defined within pmdsky.
meta:
  id: random_music_id_table_array
  endian: le
  bit-endian: le
  imports:
  - music_id_16
seq:
- id: entries
  type: random_music_id_table_array_dim_1
types:
  random_music_id_table_array_dim_0:
    seq:
    - id: entries
      type: music_id_16
      repeat: expr
      repeat-expr: 4
  random_music_id_table_array_dim_1:
    seq:
    - id: entries
      type: random_music_id_table_array_dim_0
      repeat: expr
      repeat-expr: 30
