doc: Represents an array GROUND_WAN_FILES_TABLE defined within pmdsky.
meta:
  id: ground_wan_files_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: ground_wan_files_table_array_dim_1
types:
  ground_wan_files_table_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 12
  ground_wan_files_table_array_dim_1:
    seq:
    - id: entries
      type: ground_wan_files_table_array_dim_0
      repeat: expr
      repeat-expr: 343
