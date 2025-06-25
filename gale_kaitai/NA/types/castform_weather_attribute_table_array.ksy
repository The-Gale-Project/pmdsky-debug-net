doc: Represents an array CASTFORM_WEATHER_ATTRIBUTE_TABLE defined within pmdsky.
meta:
  id: castform_weather_attribute_table_array
  endian: le
  bit-endian: le
  imports:
  - castform_weather_attributes
seq:
- id: entries
  type: castform_weather_attribute_table_array_dim_0
types:
  castform_weather_attribute_table_array_dim_0:
    seq:
    - id: entries
      type: castform_weather_attributes
      repeat: expr
      repeat-expr: 8
