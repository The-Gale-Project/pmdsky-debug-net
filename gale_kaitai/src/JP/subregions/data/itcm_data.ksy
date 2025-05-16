meta:
  id: itcm_data
  endian: le
instances:
  memory_allocation_table:
    pos: 0x0
    doc: |-
      [Runtime] Keeps track of all active heap allocations.

      The memory allocator in the ARM9 binary uses region-based memory management (see https://en.wikipedia.org/wiki/Region-based_memory_management). The heap is broken up into smaller contiguous chunks called arenas (struct mem_arena), which are in turn broken up into chunks referred to as blocks (struct mem_block). Most of the time, an allocation results in a block being split off from a free part of an existing memory arena.

      Note: This symbol isn't actually part of the ITCM, it gets created at runtime on the spot in RAM that used to contain the code that was moved to the ITCM.

      type: struct mem_alloc_table
    type: mem_alloc_table
types:
  mem_alloc_table:
  - id: n_arenas
    type: u4
  - id: default_arena
    type: mem_arena
  mem_arena:
  - id: content_flags
    type: u4
  - id: n_blocks
    type: u4
  - id: max_blocks
    type: u4
  - id: len
    type: u4
  mem_block:
  - id: available
    type: u4
  - id: used
    type: u4
enums: {}
