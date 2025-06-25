doc: Represents a struct or union wan_animation_group defined within 
  pmdsky-debug.
meta:
  id: wan_animation_group
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: pnt
  type: pointer
- id: len
  type: u2
- id: loop_start
  type: u2
