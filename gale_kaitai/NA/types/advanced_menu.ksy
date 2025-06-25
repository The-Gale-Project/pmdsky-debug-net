doc: Represents a struct or union advanced_menu defined within pmdsky-debug.
meta:
  id: advanced_menu
  endian: le
  bit-endian: le
  imports:
  - pointer
  - window_input_ctx
  - window_extra_info
seq:
- id: update
  type: pointer
- id: input_ctx
  type: window_input_ctx
- id: field_0xfc
  type: s4
- id: extra_info
  type: window_extra_info
- id: field_0x198
  type: u1
- id: field_0x199
  type: u1
- id: field_0x19a
  type: u1
- id: field_0x19b
  type: u1
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
  type: u1
- id: field_0x1ad
  type: u1
- id: field_0x1ae
  type: u1
- id: field_0x1af
  type: u1
