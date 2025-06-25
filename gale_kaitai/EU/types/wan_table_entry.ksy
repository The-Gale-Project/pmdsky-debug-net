doc: Represents a struct or union wan_table_entry defined within pmdsky-debug.
meta:
  id: wan_table_entry
  endian: le
  bit-endian: le
  imports:
  - wan_table_entry_path_array
  - wan_source_type_8
  - pointer
seq:
- id: path
  type: wan_table_entry_path_array
- id: file_externally_allocated
  type: u1
- id: source_type
  type: wan_source_type_8
- id: pack_id
  type: s2
- id: file_index
  type: s2
- id: field5_0x26
  type: u1
- id: field6_0x27
  type: u1
- id: iov_len
  type: u4
- id: reference_counter
  type: s2
- id: field9_0x2e
  type: u1
- id: field10_0x2f
  type: u1
- id: sprite_start
  type: pointer
- id: iov_base
  type: pointer
