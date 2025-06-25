doc: Represents a struct or union dse_file_chunk defined within pmdsky-debug.
meta:
  id: dse_file_chunk
  endian: le
  bit-endian: le
  imports: []
seq:
- id: signature
  type: u4
- id: field_0x4
  type: u4
- id: padding_alignment
  type: u1
- id: field_0x9
  type: u1
- id: field_0xa
  type: u2
- id: data_size
  type: u4
