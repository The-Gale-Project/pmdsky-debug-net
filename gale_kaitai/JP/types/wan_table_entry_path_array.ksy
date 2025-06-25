doc: Represents an array wan_table_entry_path defined within pmdsky.
meta:
  id: wan_table_entry_path_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: wan_table_entry_path_array_dim_0
types:
  wan_table_entry_path_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 32
