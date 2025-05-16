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
  default_memory_arena:
    pos: 0x4
    doc: |-
      [Runtime] The default memory allocation arena. This is part of MEMORY_ALLOCATION_TABLE, but is also referenced on its own by various functions.

      Note: This symbol isn't actually part of the ITCM, it gets created at runtime on the spot in RAM that used to contain the code that was moved to the ITCM.

      type: struct mem_arena
    type: mem_arena
  default_memory_arena_blocks:
    pos: 0x40
    doc: |-
      [Runtime] The block array for DEFAULT_MEMORY_ARENA.

      Note: This symbol isn't actually part of the ITCM, it gets created at runtime on the spot in RAM that used to contain the code that was moved to the ITCM.

      type: struct mem_block[256]
    type: mem_block
    repeat: expr
    repeat-expr: 256
  render_3d_functions:
    pos: 0x120
    doc: |-
      Pointers to the 4 functions available for rendering a render_3d_element (in ITCM)

      type: render_3d_element_fn_t[4]
    type: u4
    repeat: expr
    repeat-expr: 4
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
