doc: Holds the data for the enum weather_id.
meta:
  id: weather_id
  endian: le
  bit-endian: le
seq:
- id: weather_id_value
  type: b32
  enum: weather_id_enum
enums:
  weather_id_enum:
    0: weather_clear
    1: weather_sunny
    2: weather_sandstorm
    3: weather_cloudy
    4: weather_rain
    5: weather_hail
    6: weather_fog
    7: weather_snow
    8: weather_random
