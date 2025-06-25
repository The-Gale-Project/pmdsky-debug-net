doc: Represents a struct or union wan_offset defined within pmdsky-debug.
meta:
  id: wan_offset
  endian: le
  bit-endian: le
  imports:
  - uvec2_16
seq:
- id: head
  type: uvec2_16
- id: hand_left
  type: uvec2_16
- id: hand_right
  type: uvec2_16
- id: center
  type: uvec2_16
