doc: Holds the data for the enum memory_alloc_flag.
meta:
  id: memory_alloc_flag
  endian: le
  bit-endian: le
seq:
- id: memory_alloc_flag_value
  type: b32
  enum: memory_alloc_flag_enum
enums:
  memory_alloc_flag_enum:
    0: mem_in_use
    1: mem_object
    2: mem_arena
    3: mem_subarena
