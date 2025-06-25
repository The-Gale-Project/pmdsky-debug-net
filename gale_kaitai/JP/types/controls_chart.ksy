doc: Represents a struct or union controls_chart defined within pmdsky-debug.
meta:
  id: controls_chart
  endian: le
  bit-endian: le
  imports:
  - pointer
  - window_flags
  - window_extra_info
seq:
- id: update
  type: pointer
- id: flags
  type: window_flags
- id: extra_info
  type: window_extra_info
- id: state
  type: s4
- id: string_id
  type: u2
- id: field_0xa6
  type: u1
- id: field_0xa7
  type: u1
