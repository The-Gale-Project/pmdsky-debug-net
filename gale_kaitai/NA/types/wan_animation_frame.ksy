doc: Represents a struct or union wan_animation_frame defined within 
  pmdsky-debug.
meta:
  id: wan_animation_frame
  endian: le
  bit-endian: le
  imports:
  - vec2_16
seq:
- id: duration
  type: u1
- id: flag
  type: u1
- id: frame_id
  type: u2
- id: offset
  type: vec2_16
- id: shadow_offset
  type: vec2_16
