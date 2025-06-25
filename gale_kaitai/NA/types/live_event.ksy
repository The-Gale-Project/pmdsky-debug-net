doc: Represents a struct or union live_event defined within pmdsky-debug.
meta:
  id: live_event
  endian: le
  bit-endian: le
  imports:
  - vec2
seq:
- id: id
  type: s2
- id: coroutine_id
  type: u2
- id: hanger
  type: u2
- id: sector
  type: u1
- id: field_0x7
  type: u1
- id: script_id
  type: s2
- id: field_0xa
  type: u1
- id: field_0xb
  type: u1
- id: attribute_bitfield
  type: s4
- id: coord_min
  type: vec2
- id: coord_max
  type: vec2
