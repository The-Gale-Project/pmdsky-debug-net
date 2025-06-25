doc: Represents a struct or union common_routine defined within pmdsky-debug.
meta:
  id: common_routine
  endian: le
  bit-endian: le
  imports:
  - common_routine_id_16
  - pointer
seq:
- id: id
  type: common_routine_id_16
- id: field_0x2
  type: s2
- id: name
  type: pointer
