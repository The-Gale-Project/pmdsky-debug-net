doc: Represents a struct or union simple_menu defined within pmdsky-debug.
meta:
  id: simple_menu
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
- id: state
  type: s4
- id: field_0x1a0
  type: u1
- id: field_0x1a1
  type: u1
- id: field_0x1a2
  type: u1
- id: field_0x1a3
  type: u1
- id: field_0x1a4
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
  type: s4
- id: field_0x1b0
  type: s4
