doc: Represents a struct or union options_menu defined within pmdsky-debug.
meta:
  id: options_menu
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
- id: input_ctx
  type: window_input_ctx
- id: flags
  type: window_flags
- id: extra_info
  type: window_extra_info
- id: items
  type: pointer
- id: field_0x19c
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
  type: s4
- id: field_0x1ac
  type: s4
- id: field_0x1b0
  type: s4
- id: field_0x1b4
  type: s4
