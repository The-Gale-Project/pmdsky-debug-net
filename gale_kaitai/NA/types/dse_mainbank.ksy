doc: Represents a struct or union dse_mainbank defined within pmdsky-debug.
meta:
  id: dse_mainbank
  endian: le
  bit-endian: le
  imports:
  - pointer
  - file_stream
seq:
- id: id
  type: u2
- id: num_wavi
  type: u2
- id: pcm_data_offset
  type: u4
- id: wavi_data
  type: pointer
- id: field_0xc
  type: u4
- id: field_0x10
  type: u4
- id: file
  type: file_stream
- id: next
  type: pointer
