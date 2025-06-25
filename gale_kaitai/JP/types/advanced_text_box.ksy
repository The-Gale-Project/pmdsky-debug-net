doc: Represents a struct or union advanced_text_box defined within pmdsky-debug.
meta:
  id: advanced_text_box
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
- id: field_0xfc
  type: s2
- id: field_0xfe
  type: s2
- id: field_0x100
  type: s2
- id: field_0x102
  type: s2
- id: flags
  type: window_flags
- id: extra_info
  type: window_extra_info
- id: window_id
  type: s1
- id: field_0x1a1
  type: u1
- id: field_0x1a2
  type: u1
- id: field_0x1a3
  type: u1
- id: callback
  type: pointer
- id: callback_with_arg
  type: pointer
- id: callback_arg
  type: pointer
- id: flags2
  type: u4
- id: field_0x1b4
  type: pointer
- id: field_0x1b8
  type: pointer
- id: state
  type: s4
- id: field_0x1c0
  type: u1
- id: field_0x1c1
  type: u1
- id: field_0x1c2
  type: u1
- id: partial_menu
  type: u1
- id: field_0x1c4
  type: u1
- id: field_0x1c5
  type: u1
- id: field_0x1c6
  type: u1
- id: field_0x1c7
  type: u1
