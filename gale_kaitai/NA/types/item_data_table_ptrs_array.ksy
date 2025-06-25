doc: Represents an array ITEM_DATA_TABLE_PTRS defined within pmdsky.
meta:
  id: item_data_table_ptrs_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: item_data_table_ptrs_array_dim_0
types:
  item_data_table_ptrs_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 3
