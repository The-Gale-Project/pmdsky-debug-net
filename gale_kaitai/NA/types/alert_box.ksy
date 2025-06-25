doc: Represents a struct or union alert_box defined within pmdsky-debug.
meta:
  id: alert_box
  endian: le
  bit-endian: le
  imports:
  - dialogue_display_ctx
  - alert_box_field_0x124_array
seq:
- id: window_id
  type: s1
- id: field_0x1
  type: u1
- id: field_0x2
  type: u1
- id: field_0x3
  type: u1
- id: state
  type: s4
- id: display_ctx
  type: dialogue_display_ctx
- id: field_0x124
  type: alert_box_field_0x124_array
- id: field_0x644
  type: s2
- id: idx1
  type: s2
- id: idx2
  type: s2
- id: field_0x64a
  type: s2
- id: field_0x64c
  type: s2
- id: field_0x64e
  type: u1
- id: field_0x64f
  type: u1
