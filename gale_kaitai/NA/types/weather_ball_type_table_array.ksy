doc: Represents an array WEATHER_BALL_TYPE_TABLE defined within pmdsky.
meta:
  id: weather_ball_type_table_array
  endian: le
  bit-endian: le
  imports:
  - type_id_8
seq:
- id: entries
  type: weather_ball_type_table_array_dim_0
types:
  weather_ball_type_table_array_dim_0:
    seq:
    - id: entries
      type: type_id_8
      repeat: expr
      repeat-expr: 8
