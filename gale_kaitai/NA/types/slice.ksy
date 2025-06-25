doc: Represents a struct or union slice defined within pmdsky-debug.
meta:
  id: slice
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: data
  type: pointer
- id: capacity
  type: u4
- id: length
  type: u4
