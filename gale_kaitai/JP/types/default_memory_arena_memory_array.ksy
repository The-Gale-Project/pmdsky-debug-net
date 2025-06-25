doc: Represents an array DEFAULT_MEMORY_ARENA_MEMORY defined within pmdsky.
meta:
  id: default_memory_arena_memory_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: default_memory_arena_memory_array_dim_0
types:
  default_memory_arena_memory_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 1991680
