doc: Represents a struct or union playback_controls_menu defined within 
  pmdsky-debug.
meta:
  id: playback_controls_menu
  endian: le
  bit-endian: le
  imports:
  - pointer
  - window_input_ctx
  - window_flags
  - window_extra_info
seq:
- id: update
  type: pointer
- id: field_0x4
  type: pointer
- id: input_ctx
  type: window_input_ctx
- id: flags
  type: window_flags
- id: extra_info
  type: window_extra_info
- id: items1
  type: pointer
- id: items2
  type: pointer
- id: state
  type: s4
- id: field_0x1a8
  type: u1
- id: field_0x1a9
  type: u1
- id: field_0x1aa
  type: u1
- id: field_0x1ab
  type: u1
- id: field_0x1ac
  type: u4
- id: field_0x1b0
  type: u1
- id: field_0x1b1
  type: u1
- id: field_0x1b2
  type: u1
- id: field_0x1b3
  type: u1
