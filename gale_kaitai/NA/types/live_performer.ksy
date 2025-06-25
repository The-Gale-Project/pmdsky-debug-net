doc: Represents a struct or union live_performer defined within pmdsky-debug.
meta:
  id: live_performer
  endian: le
  bit-endian: le
  imports:
  - live_entity
  - direction_id_8
  - vec2
  - animation
seq:
- id: field_0x0
  type: u1
- id: field_0x1
  type: u1
- id: field_0x2
  type: u1
- id: field_0x3
  type: u1
- id: entity
  type: live_entity
- id: attribute_bitfield
  type: u4
- id: direction
  type: direction_id_8
- id: field_0x12d
  type: u1
- id: field_0x12e
  type: u1
- id: field_0x12f
  type: u1
- id: coord_min
  type: vec2
- id: coord_max
  type: vec2
- id: height
  type: s4
- id: second_height
  type: s4
- id: direction_should_change
  type: u1
- id: field_0x149
  type: u1
- id: field_0x14a
  type: u1
- id: field_0x14b
  type: u1
- id: effect_flag
  type: s2
- id: effect_id
  type: s2
- id: animation
  type: animation
