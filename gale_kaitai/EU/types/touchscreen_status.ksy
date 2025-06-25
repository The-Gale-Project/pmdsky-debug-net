doc: Represents a struct or union touchscreen_status defined within 
  pmdsky-debug.
meta:
  id: touchscreen_status
  endian: le
  bit-endian: le
  imports:
  - touchscreen_position
seq:
- id: current_position
  type: touchscreen_position
- id: field_0xc
  type: u1
- id: field_0xd
  type: u1
- id: field_0xe
  type: u1
- id: field_0xf
  type: u1
- id: pressed_frames
  type: s4
- id: unpressed_frames
  type: s4
- id: x_pos_mirror
  type: s4
- id: y_pos_mirror
  type: s4
- id: last_x_pos
  type: s4
- id: last_y_pos
  type: s4
- id: first_x_pos
  type: s4
- id: first_y_pos
  type: s4
- id: field_0x30
  type: u1
- id: field_0x31
  type: u1
- id: field_0x32
  type: u1
- id: field_0x33
  type: u1
- id: field_0x34
  type: u1
- id: field_0x35
  type: u1
- id: field_0x36
  type: u1
- id: field_0x37
  type: u1
- id: current_position_mirror
  type: touchscreen_position
- id: current_position_mirror_1
  type: touchscreen_position
- id: current_position_mirror_2
  type: touchscreen_position
- id: current_position_mirror_3
  type: touchscreen_position
