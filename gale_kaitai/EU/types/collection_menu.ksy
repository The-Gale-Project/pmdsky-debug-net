doc: Represents a struct or union collection_menu defined within pmdsky-debug.
meta:
  id: collection_menu
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
- id: field_0x198
  type: pointer
- id: field_0x19c
  type: pointer
- id: field_0x1a0
  type: u4
- id: field_0x1a4
  type: u4
- id: field_0x1a8
  type: pointer
- id: state
  type: s4
- id: field_0x1b0
  type: u1
- id: field_0x1b1
  type: u1
- id: field_0x1b2
  type: u1
- id: field_0x1b3
  type: u1
- id: field_0x1b4
  type: u4
- id: field_0x1b8
  type: u4
- id: field_0x1bc
  type: s4
- id: width
  type: s4
- id: field_0x1c4
  type: u1
- id: field_0x1c5
  type: u1
- id: field_0x1c6
  type: u1
- id: field_0x1c7
  type: u1
- id: field_0x1c8
  type: u1
- id: field_0x1c9
  type: u1
- id: field_0x1ca
  type: u1
- id: field_0x1cb
  type: u1
