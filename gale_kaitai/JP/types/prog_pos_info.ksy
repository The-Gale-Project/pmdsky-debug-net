doc: Represents a struct or union prog_pos_info defined within pmdsky-debug.
meta:
  id: prog_pos_info
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: file
  type: pointer
- id: line
  type: s4
