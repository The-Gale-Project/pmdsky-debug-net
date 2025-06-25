doc: Represents an array move_data_table_entries defined within pmdsky.
meta:
  id: move_data_table_entries_array
  endian: le
  bit-endian: le
  imports:
  - move_data
seq:
- id: entries
  type: move_data_table_entries_array_dim_0
types:
  move_data_table_entries_array_dim_0:
    seq:
    - id: entries
      type: move_data
      repeat: expr
      repeat-expr: 559
