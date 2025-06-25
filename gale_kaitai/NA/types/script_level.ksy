doc: Represents a struct or union script_level defined within pmdsky-debug.
meta:
  id: script_level
  endian: le
  bit-endian: le
  imports:
  - weather_id
  - pointer
seq:
- id: mapty
  type: u2
- id: field_0x2
  type: u2
- id: mapid
  type: u2
- id: weather_id
  type: weather_id
- id: name
  type: pointer
