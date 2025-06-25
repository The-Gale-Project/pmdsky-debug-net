doc: Represents a struct or union inventory_menu defined within pmdsky-debug.
meta:
  id: inventory_menu
  endian: le
  bit-endian: le
  imports:
  - pointer
  - inventory_menu_input_ctx
  - window_flags
  - window_extra_info
seq:
- id: update
  type: pointer
- id: input_ctx
  type: inventory_menu_input_ctx
- id: field_0xf4
  type: u1
- id: field_0xf5
  type: u1
- id: field_0xf6
  type: u1
- id: field_0xf7
  type: u1
- id: flags
  type: window_flags
- id: extra_info
  type: window_extra_info
- id: field_0x194
  type: pointer
- id: field_0x198
  type: u4
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
