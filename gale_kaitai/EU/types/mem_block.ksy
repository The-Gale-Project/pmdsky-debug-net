doc: Represents a struct or union mem_block defined within pmdsky-debug.
meta:
  id: mem_block
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: f_in_use
  type: b1
- id: f_object
  type: b1
- id: f_arena
  type: b1
- id: content_flags_unused
  type: b29
- id: f_alloc_in_use
  type: b1
- id: f_alloc_object
  type: b1
- id: f_alloc_arena
  type: b1
- id: f_alloc_subarena
  type: b1
- id: allocator_flags_unused
  type: b28
- id: user_flags
  type: b8
- id: f_user_alloc_in_use
  type: b1
- id: f_user_alloc_object
  type: b1
- id: f_user_alloc_arena
  type: b1
- id: f_user_alloc_subarena
  type: b1
- id: user_flags_unused
  type: b20
- id: data
  type: pointer
- id: available
  type: u4
- id: used
  type: u4
