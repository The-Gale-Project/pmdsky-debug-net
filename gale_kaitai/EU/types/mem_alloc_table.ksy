doc: Represents a struct or union mem_alloc_table defined within pmdsky-debug.
meta:
  id: mem_alloc_table
  endian: le
  bit-endian: le
  imports:
  - mem_arena
  - mem_alloc_table_arenas_array
seq:
- id: n_arenas
  type: u4
- id: default_arena
  type: mem_arena
- id: arenas
  type: mem_alloc_table_arenas_array
