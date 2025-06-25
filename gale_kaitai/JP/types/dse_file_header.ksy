doc: Represents a struct or union dse_file_header defined within pmdsky-debug.
meta:
  id: dse_file_header
  endian: le
  bit-endian: le
  imports:
  - dse_file_header_field_0x10_array
  - dse_file_header_file_name_array
seq:
- id: signature
  type: u4
- id: field_0x4
  type: u4
- id: field_0x8
  type: u4
- id: version
  type: u2
- id: id
  type: u2
- id: field_0x10
  type: dse_file_header_field_0x10_array
- id: file_name
  type: dse_file_header_file_name_array
