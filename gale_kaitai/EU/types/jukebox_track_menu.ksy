doc: Represents a struct or union jukebox_track_menu defined within 
  pmdsky-debug.
meta:
  id: jukebox_track_menu
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
- id: items
  type: pointer
- id: state
  type: s4
- id: field_0x1a4
  type: u1
- id: field_0x1a5
  type: u1
- id: field_0x1a6
  type: u1
- id: field_0x1a7
  type: u1
- id: field_0x1a8
  type: u4
