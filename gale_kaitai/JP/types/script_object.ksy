doc: Represents a struct or union script_object defined within pmdsky-debug.
meta:
  id: script_object
  endian: le
  bit-endian: le
  imports:
  - pointer
  - script_object_unused_array
seq:
- id: field_0x0
  type: s2
- id: field_0x2
  type: u1
- id: field_0x3
  type: u1
- id: name
  type: pointer
- id: field_0x8
  type: u1
- id: unused
  type: script_object_unused_array
