doc: Represents a struct or union pack_alloc_and_load_result defined within 
  pmdsky-debug.
meta:
  id: pack_alloc_and_load_result
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: data
  type: pointer
- id: length
  type: u4
