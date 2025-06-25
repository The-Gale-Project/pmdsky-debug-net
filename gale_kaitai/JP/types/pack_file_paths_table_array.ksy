doc: Represents an array PACK_FILE_PATHS_TABLE defined within pmdsky.
meta:
  id: pack_file_paths_table_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: pack_file_paths_table_array_dim_0
types:
  pack_file_paths_table_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 6
