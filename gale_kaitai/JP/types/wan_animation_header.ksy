doc: Represents a struct or union wan_animation_header defined within 
  pmdsky-debug.
meta:
  id: wan_animation_header
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: frames
  type: pointer
- id: frame_offsets
  type: pointer
- id: animations
  type: pointer
- id: nb_animation_groups
  type: u2
- id: allocation_for_max_frame
  type: u2
- id: field5_0x10
  type: u1
- id: field6_0x11
  type: u1
- id: field7_0x12
  type: u1
- id: field8_0x13
  type: u1
- id: is_256_color_alt
  type: u2
- id: field9_0x16
  type: u1
- id: field10_0x17
  type: u1
