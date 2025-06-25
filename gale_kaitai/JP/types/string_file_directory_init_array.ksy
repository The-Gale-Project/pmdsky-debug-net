doc: Represents an array STRING_FILE_DIRECTORY_INIT defined within pmdsky.
meta:
  id: string_file_directory_init_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: string_file_directory_init_array_dim_0
types:
  string_file_directory_init_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 40
