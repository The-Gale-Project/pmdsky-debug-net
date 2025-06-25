doc: Represents a struct or union script_entity defined within pmdsky-debug.
meta:
  id: script_entity
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: type
  type: u2
- id: entid
  type: u2
- id: name
  type: pointer
- id: field_0x8
  type: u2
- id: field_0xa
  type: u1
- id: field_0xb
  type: u1
