doc: Represents a struct or union dse_sequence defined within pmdsky-debug.
meta:
  id: dse_sequence
  endian: le
  bit-endian: le
  imports:
  - pointer
  - dse_fade
  - dse_sequence_field_0x88_array
  - dse_sequence_field_0x99_array
  - dse_sequence_tracks_array
seq:
- id: initialized
  type: s1
- id: is_stopped
  type: s1
- id: restart
  type: s1
- id: has_looped
  type: u1
- id: is_playing
  type: s1
- id: field_0x5
  type: s1
- id: field_0x6
  type: s1
- id: field_0x7
  type: s1
- id: field_0x8
  type: s1
- id: field_0x9
  type: s1
- id: field_0xa
  type: s1
- id: field_0xb
  type: u1
- id: active_fades_flags
  type: u1
- id: num_tracks_playing
  type: u1
- id: num_tracks
  type: s1
- id: num_tracks_2
  type: s1
- id: num_channels
  type: s1
- id: field_0x11
  type: u1
- id: field_0x12
  type: u1
- id: global_volume_index
  type: u1
- id: effect_id
  type: u1
- id: seq_ticks_per_eighth_beat
  type: u1
- id: field_0x16
  type: u1
- id: bpm
  type: u1
- id: field_0x18
  type: u1
- id: field_0x19
  type: u1
- id: ticks_until_update
  type: s2
- id: file
  type: pointer
- id: field_0x20
  type: s4
- id: synth
  type: pointer
- id: id
  type: s4
- id: field_0x2c
  type: u2
- id: field_0x30
  type: u2
- id: total_driver_ticks_at_reset
  type: s4
- id: field_0x38
  type: s4
- id: seq_tick_counter
  type: s4
- id: time_since_last_seq_tick
  type: s4
- id: beatsplit_times_ticktime
  type: s4
- id: microseconds_per_beat
  type: s4
- id: tempo
  type: dse_fade
- id: bend
  type: dse_fade
- id: volume
  type: dse_fade
- id: pan
  type: dse_fade
- id: field_0x88
  type: dse_sequence_field_0x88_array
- id: volume_fade_target
  type: s1
- id: field_0x99
  type: dse_sequence_field_0x99_array
- id: signal_callback
  type: pointer
- id: callback_arg
  type: pointer
- id: next
  type: pointer
- id: tracks
  type: dse_sequence_tracks_array
