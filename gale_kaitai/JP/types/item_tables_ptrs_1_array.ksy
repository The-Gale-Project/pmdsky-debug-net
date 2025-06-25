doc: Represents an array ITEM_TABLES_PTRS_1 defined within pmdsky.
meta:
  id: item_tables_ptrs_1_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: item_tables_ptrs_1_array_dim_0
types:
  item_tables_ptrs_1_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 26
