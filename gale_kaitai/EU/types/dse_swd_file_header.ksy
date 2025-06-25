doc: Represents a struct or union dse_swd_file_header defined within 
  pmdsky-debug.
meta:
  id: dse_swd_file_header
  endian: le
  bit-endian: le
  imports:
  - dse_file_header
  - dse_swd_file_header_field_0x30_array
  - dse_swd_file_header_field_0x42_array
seq:
- id: base_file_header
  type: dse_file_header
- id: field_0x30
  type: dse_swd_file_header_field_0x30_array
- id: mainbank_id
  type: u2
- id: field_0x42
  type: dse_swd_file_header_field_0x42_array
- id: num_waves
  type: u2
- id: num_instruments
  type: u2
- id: num_keygroups
  type: u1
- id: sample_container_kind
  type: u1
- id: wavi_data_size
  type: u4
