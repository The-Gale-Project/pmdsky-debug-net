meta:
  id: itcm_data
  endian: le
  imports:
  - ../../types/mem_alloc_table
  - ../../types/render_3d_functions_array
instances:
  memory_allocation_table:
    pos: 0x0
    type: mem_alloc_table
    doc: |-
      [Runtime] Keeps track of all active heap allocations.

      The memory allocator in the ARM9 binary uses region-based memory management (see https://en.wikipedia.org/wiki/Region-based_memory_management). The heap is broken up into smaller contiguous chunks called arenas (struct mem_arena), which are in turn broken up into chunks referred to as blocks (struct mem_block). Most of the time, an allocation results in a block being split off from a free part of an existing memory arena.

      Note: This symbol isn't actually part of the ITCM, it gets created at runtime on the spot in RAM that used to contain the code that was moved to the ITCM.

      type: struct mem_alloc_table
  render_3d_functions:
    pos: 0x120
    type: render_3d_functions_array
    doc: |-
      Pointers to the 4 functions available for rendering a render_3d_element (in ITCM)

      type: render_3d_element_fn_t[4]
