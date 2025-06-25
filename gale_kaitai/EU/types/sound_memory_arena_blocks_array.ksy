doc: Represents an array SOUND_MEMORY_ARENA_BLOCKS defined within pmdsky.
meta:
  id: sound_memory_arena_blocks_array
  endian: le
  bit-endian: le
  imports:
  - mem_block
seq:
- id: entries
  type: sound_memory_arena_blocks_array_dim_0
types:
  sound_memory_arena_blocks_array_dim_0:
    seq:
    - id: entries
      type: mem_block
      repeat: expr
      repeat-expr: 20
