doc: Represents an array SOUND_MEMORY_ARENA_MEMORY defined within pmdsky.
meta:
  id: sound_memory_arena_memory_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: sound_memory_arena_memory_array_dim_0
types:
  sound_memory_arena_memory_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 245252
