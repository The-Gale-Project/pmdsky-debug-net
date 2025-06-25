doc: Represents an array GROUND_MEMORY_ARENA_1_BLOCKS defined within pmdsky.
meta:
  id: ground_memory_arena_1_blocks_array
  endian: le
  bit-endian: le
  imports:
  - mem_block
seq:
- id: entries
  type: ground_memory_arena_1_blocks_array_dim_0
types:
  ground_memory_arena_1_blocks_array_dim_0:
    seq:
    - id: entries
      type: mem_block
      repeat: expr
      repeat-expr: 52
