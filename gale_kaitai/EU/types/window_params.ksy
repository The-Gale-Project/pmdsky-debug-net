doc: Represents a struct or union window_params defined within pmdsky-debug.
meta:
  id: window_params
  endian: le
  bit-endian: le
  imports:
  - pointer
  - screen_8
  - box_type_8
seq:
- id: update
  type: pointer
- id: x_offset
  type: u1
- id: y_offset
  type: u1
- id: width
  type: u1
- id: height
  type: u1
- id: screen
  type: screen_8
- id: box_type
  type: box_type_8
- id: field_0xa
  type: u1
- id: field_0xb
  type: u1
- id: contents
  type: pointer
