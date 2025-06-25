doc: Represents an array DEFAULT_MEMORY_ARENA_BLOCKS defined within pmdsky.
meta:
  id: default_memory_arena_blocks_array
  endian: le
  bit-endian: le
  imports:
  - mem_block
seq:
- id: entries
  type: default_memory_arena_blocks_array_dim_0
types:
  default_memory_arena_blocks_array_dim_0:
    seq:
    - id: entries
      type: mem_block
      repeat: expr
      repeat-expr: 256
