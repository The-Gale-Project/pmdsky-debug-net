doc: Represents an array GROUND_WEATHER_TABLE defined within pmdsky.
meta:
  id: ground_weather_table_array
  endian: le
  bit-endian: le
  imports:
  - ground_weather_entry
seq:
- id: entries
  type: ground_weather_table_array_dim_0
types:
  ground_weather_table_array_dim_0:
    seq:
    - id: entries
      type: ground_weather_entry
      repeat: expr
      repeat-expr: 12
