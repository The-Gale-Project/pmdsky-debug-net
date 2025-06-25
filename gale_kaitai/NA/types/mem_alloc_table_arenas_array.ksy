doc: Represents an array mem_alloc_table_arenas defined within pmdsky.
meta:
  id: mem_alloc_table_arenas_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: mem_alloc_table_arenas_array_dim_0
types:
  mem_alloc_table_arenas_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 8
