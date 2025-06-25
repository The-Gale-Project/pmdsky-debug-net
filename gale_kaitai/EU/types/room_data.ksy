doc: Represents a struct or union room_data defined within pmdsky-debug.
meta:
  id: room_data
  endian: le
  bit-endian: le
  imports:
  - position
seq:
- id: room_id
  type: u1
- id: field_0x1
  type: u1
- id: top_left_corner
  type: position
- id: bottom_right_corner
  type: position
- id: field_0xa
  type: u1
- id: field_0xb
  type: u1
- id: field_0xc
  type: u4
- id: field_0x10
  type: u4
- id: field_0x14
  type: u4
- id: field_0x18
  type: u4
