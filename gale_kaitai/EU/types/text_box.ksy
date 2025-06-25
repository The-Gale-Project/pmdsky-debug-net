doc: Represents a struct or union text_box defined within pmdsky-debug.
meta:
  id: text_box
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: window_id
  type: s1
- id: field_0x1
  type: u1
- id: field_0x2
  type: u1
- id: field_0x3
  type: u1
- id: callback
  type: pointer
- id: callback_with_arg
  type: pointer
- id: update
  type: pointer
- id: state
  type: s4
- id: callback_arg
  type: pointer
