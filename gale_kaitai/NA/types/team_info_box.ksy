doc: Represents a struct or union team_info_box defined within pmdsky-debug.
meta:
  id: team_info_box
  endian: le
  bit-endian: le
  imports:
  - pointer
  - portrait_params
  - team_info_box_fields_0x1c_array
seq:
- id: update
  type: pointer
- id: field_0x4
  type: s1
- id: field_0x5
  type: u1
- id: field_0x6
  type: u1
- id: field_0x7
  type: u1
- id: portrait
  type: portrait_params
- id: field_0x18
  type: s4
- id: fields_0x1c
  type: team_info_box_fields_0x1c_array
- id: state
  type: s4
- id: field_0x374
  type: s4
