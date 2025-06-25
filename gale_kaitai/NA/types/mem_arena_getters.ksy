doc: Represents a struct or union mem_arena_getters defined within pmdsky-debug.
meta:
  id: mem_arena_getters
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: get_alloc_arena
  type: pointer
- id: get_free_arena
  type: pointer
