doc: Represents a struct or union castform_weather_attributes defined within 
  pmdsky-debug.
meta:
  id: castform_weather_attributes
  endian: le
  bit-endian: le
  imports:
  - type_id_8
  - monster_id_16
seq:
- id: castform_type
  type: type_id_8
- id: padding
  type: u1
- id: castform_male_id
  type: monster_id_16
- id: castform_female_id
  type: monster_id_16
