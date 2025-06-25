doc: Represents a struct or union pack_file_opened defined within pmdsky-debug.
meta:
  id: pack_file_opened
  endian: le
  bit-endian: le
  imports:
  - pointer
  - file_stream
seq:
- id: table_of_content
  type: pointer
- id: zero
  type: u4
- id: nb_entry_table_of_content
  type: u4
- id: opened_file
  type: file_stream
