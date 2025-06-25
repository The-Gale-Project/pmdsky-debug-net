doc: Represents an array WEATHER_BALL_DAMAGE_MULT_TABLE defined within pmdsky.
meta:
  id: weather_ball_damage_mult_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: weather_ball_damage_mult_table_array_dim_0
types:
  weather_ball_damage_mult_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 8
