doc: Represents a struct or union track_data defined within pmdsky-debug.
meta:
  id: track_data
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: field_0x0
  type: u1
- id: field_0x1
  type: u1
- id: active
  type: u1
- id: field_0x3
  type: u1
- id: field_0x4
  type: u1
- id: field_0x5
  type: u1
- id: field_0x6
  type: u1
- id: field_0x7
  type: u1
- id: play_amount
  type: s4
- id: event_delay
  type: s4
- id: field_0x10
  type: u1
- id: field_0x11
  type: u1
- id: field_0x12
  type: u1
- id: field_0x13
  type: u1
- id: field_0x14
  type: u1
- id: field_0x15
  type: u1
- id: field_0x16
  type: u1
- id: field_0x17
  type: u1
- id: track_data_start
  type: pointer
- id: current_event
  type: pointer
