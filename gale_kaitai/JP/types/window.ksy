doc: Represents a struct or union window defined within pmdsky-debug.
meta:
  id: window
  endian: le
  bit-endian: le
  imports:
  - window_params
  - pointer
  - render_3d_element_64
  - window_trailer
seq:
- id: params
  type: window_params
- id: subwindow_id
  type: s1
- id: field_0x11
  type: u1
- id: field_0x12
  type: u2
- id: field_0x14
  type: pointer
- id: field_0x18
  type: s4
- id: field_0x1c
  type: s4
- id: field_0x20
  type: u4
- id: field_0x24
  type: u1
- id: field_0x25
  type: u1
- id: field_0x26
  type: u1
- id: field_0x27
  type: u1
- id: field_0x28
  type: s4
- id: field_0x2c
  type: u1
- id: field_0x2d
  type: u1
- id: field_0x2e
  type: u1
- id: field_0x2f
  type: u1
- id: field_0x30
  type: u2
- id: field_0x32
  type: u1
- id: field_0x33
  type: u1
- id: backdrop
  type: render_3d_element_64
- id: frame
  type: render_3d_element_64
- id: field_0xb4
  type: u1
- id: field_0xb5
  type: u1
- id: valid
  type: s1
- id: field_0xb7
  type: u1
- id: field_0xb8
  type: s4
- id: trailer
  type: window_trailer
