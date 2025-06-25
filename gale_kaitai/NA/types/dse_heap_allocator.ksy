doc: Represents a struct or union dse_heap_allocator defined within 
  pmdsky-debug.
meta:
  id: dse_heap_allocator
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: allocate_fun
  type: pointer
- id: free_fun
  type: pointer
- id: arg
  type: pointer
