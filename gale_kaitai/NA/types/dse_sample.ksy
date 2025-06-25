doc: Represents a struct or union dse_sample defined within pmdsky-debug.
meta:
  id: dse_sample
  endian: le
  bit-endian: le
  imports:
  - dse_sample_field_0x0_array
  - dse_sample_field_0x4_array
  - dse_sample_field_0xa_array
  - pointer
seq:
- id: field_0x0
  type: dse_sample_field_0x0_array
- id: sample_format
  type: u1
- id: field_0x4
  type: dse_sample_field_0x4_array
- id: psg_duty
  type: u1
- id: field_0xa
  type: dse_sample_field_0xa_array
- id: sample_pcm_data
  type: pointer
- id: sample_loop_start
  type: s4
- id: sample_size
  type: s4
