doc: Represents a struct or union screen_fade defined within pmdsky-debug.
meta:
  id: screen_fade
  endian: le
  bit-endian: le
  imports:
  - fade_status
seq:
- id: field0_0x0
  type: u1
- id: field1_0x1
  type: u1
- id: field2_0x2
  type: u1
- id: field3_0x3
  type: u1
- id: status
  type: fade_status
- id: remaining_frames
  type: s4
- id: duration
  type: s4
- id: target_delta_brightness
  type: s2
- id: max_brightness
  type: s2
- id: delta_brightness
  type: s2
- id: padding
  type: s2
