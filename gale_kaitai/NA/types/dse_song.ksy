doc: Represents a struct or union dse_song defined within pmdsky-debug.
meta:
  id: dse_song
  endian: le
  bit-endian: le
  imports:
  - dse_song_field_0x19_array
seq:
- id: song_id
  type: s2
- id: ticks_per_beat
  type: u2
- id: field_0x4
  type: u1
- id: field_0x5
  type: u1
- id: num_tracks
  type: u1
- id: num_channels
  type: u1
- id: field_0x8
  type: u4
- id: field_0xc
  type: u4
- id: field_0x10
  type: u4
- id: field_0x14
  type: u4
- id: flags
  type: u1
- id: global_volume_index
  type: u1
- id: effect_group_id
  type: u1
- id: field_0x17
  type: u1
- id: max_effect_instances
  type: u1
- id: field_0x19
  type: dse_song_field_0x19_array
