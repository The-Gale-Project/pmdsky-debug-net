doc: Represents a struct or union mem_arena defined within pmdsky-debug.
meta:
  id: mem_arena
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: content_flags
  type: u4
- id: parent
  type: pointer
- id: blocks
  type: pointer
- id: n_blocks
  type: u4
- id: max_blocks
  type: u4
- id: data
  type: pointer
- id: len
  type: u4
