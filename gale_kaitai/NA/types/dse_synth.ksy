doc: Represents a struct or union dse_synth defined within pmdsky-debug.
meta:
  id: dse_synth
  endian: le
  bit-endian: le
  imports:
  - pointer
  - dse_synth_channels_array
seq:
- id: field_0x0
  type: u1
- id: num_channels
  type: u1
- id: global_volume
  type: s1
- id: global_volume_index
  type: s1
- id: bend
  type: u2
- id: volume
  type: s1
- id: pan
  type: s1
- id: song_and_global_volume
  type: s1
- id: clear_volume_and_timer
  type: u1
- id: field_0xa
  type: u1
- id: num_voices
  type: u1
- id: next
  type: pointer
- id: channels
  type: dse_synth_channels_array
