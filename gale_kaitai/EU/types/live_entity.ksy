doc: Represents a struct or union live_entity defined within pmdsky-debug.
meta:
  id: live_entity
  endian: le
  bit-endian: le
  imports:
  - uvec2
  - direction_id_8
  - vec2
  - script_routine
seq:
- id: id
  type: s2
- id: kind
  type: s2
- id: is_enabled
  type: u1
- id: field_0x5
  type: u1
- id: hanger
  type: u2
- id: sector
  type: u1
- id: field_0x9
  type: s1
- id: field_0xa
  type: s2
- id: collision_box_size
  type: uvec2
- id: collision_box_size_div2
  type: uvec2
- id: initial_direction
  type: direction_id_8
- id: field_0x1d
  type: u1
- id: field_0x1e
  type: u1
- id: field_0x1f
  type: u1
- id: initial_pos
  type: vec2
- id: limit_min_pos
  type: vec2
- id: limit_max_pos
  type: vec2
- id: routine
  type: script_routine
