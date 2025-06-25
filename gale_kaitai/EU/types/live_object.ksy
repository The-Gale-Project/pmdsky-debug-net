doc: Represents a struct or union live_object defined within pmdsky-debug.
meta:
  id: live_object
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
- id: field_0x128
  type: u1
- id: field_0x129
  type: u1
- id: field_0x12a
  type: u1
- id: field_0x12b
  type: u1
- id: attribute_bitfield
  type: u4
- id: direction
  type: direction_id_8
- id: field_0x131
  type: u1
- id: field_0x132
  type: u1
- id: field_0x133
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
- id: field_0x14d
  type: u1
- id: field_0x14e
  type: u1
- id: field_0x14f
  type: u1
- id: effect_flag
  type: s2
- id: effect_id
  type: s2
- id: animation
  type: animation
