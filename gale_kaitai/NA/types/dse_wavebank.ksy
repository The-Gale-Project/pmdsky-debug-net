doc: Represents a struct or union dse_wavebank defined within pmdsky-debug.
meta:
  id: dse_wavebank
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: file
  type: pointer
- id: id
  type: u2
- id: mainbank_id
  type: u2
- id: num_waves
  type: s2
- id: num_instruments
  type: u2
- id: num_keygroups
  type: u1
- id: sample_container_kind
  type: u1
- id: field_0xe
  type: u2
- id: wavi_chunk_location
  type: pointer
- id: prgi_chunk_location
  type: pointer
- id: kgrp_chunk_location
  type: pointer
- id: pcmd_chunk_location
  type: pointer
- id: pcm_data_size
  type: u4
- id: next
  type: pointer
