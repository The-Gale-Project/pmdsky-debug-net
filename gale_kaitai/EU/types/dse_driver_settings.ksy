doc: Represents a struct or union dse_driver_settings defined within 
  pmdsky-debug.
meta:
  id: dse_driver_settings
  endian: le
  bit-endian: le
  imports:
  - pointer
  - dse_heap_allocator
seq:
- id: error_flags
  type: u4
- id: field_0x4
  type: u4
- id: heap_location
  type: pointer
- id: heap_size
  type: u4
- id: field_0xc
  type: u1
- id: is_tick_rate_60hz
  type: u1
- id: field_0xe
  type: u1
- id: field_0xf
  type: u1
- id: field_0x10
  type: s2
- id: field_0x12
  type: s2
- id: num_se_sequences
  type: u2
- id: tracks_per_se_sequence
  type: u2
- id: heap_allocator
  type: dse_heap_allocator
- id: error_callback
  type: pointer
- id: error2_callback
  type: pointer
- id: field_0x30
  type: u4
