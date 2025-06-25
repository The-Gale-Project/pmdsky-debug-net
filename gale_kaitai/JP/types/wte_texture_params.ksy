doc: Represents a struct or union wte_texture_params defined within 
  pmdsky-debug.
meta:
  id: wte_texture_params
  endian: le
  bit-endian: le
  imports:
  - texture_format_3
seq:
- id: texture_smult
  type: b3
- id: texture_tmult
  type: b3
- id: unused6
  type: b2
- id: format
  type: texture_format_3
- id: repeat_x
  type: b1
- id: repeat_y
  type: b1
- id: unusedd
  type: b3
