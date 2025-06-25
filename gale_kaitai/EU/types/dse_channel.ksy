doc: Represents a struct or union dse_channel defined within pmdsky-debug.
meta:
  id: dse_channel
  endian: le
  bit-endian: le
  imports:
  - dse_fade
  - dse_channel_field_0x5a_array
  - sound_envelope_parameters
  - dse_channel_lfo_settings_array
  - pointer
seq:
- id: sequence_id
  type: u4
- id: channel_flags
  type: u1
- id: channel_index
  type: u1
- id: field_0x7
  type: u1
- id: field_0x8
  type: u1
- id: field_0x9
  type: u1
- id: total_num_voices
  type: s1
- id: bend_jitter_amplitude
  type: s2
- id: note_random_region_begin
  type: u1
- id: note_random_region_end
  type: u1
- id: swd_id
  type: u2
- id: selected_instrument_index
  type: s2
- id: field_0x14
  type: s2
- id: field_0x16
  type: s2
- id: bend_final
  type: u2
- id: volume_final
  type: u2
- id: pan_final
  type: s2
- id: bend
  type: dse_fade
- id: volume
  type: dse_fade
- id: pan
  type: dse_fade
- id: field_0x4c
  type: u4
- id: expression
  type: u1
- id: lfo_amplitude
  type: u1
- id: key_bend
  type: s2
- id: tuning
  type: s2
- id: field_0x56
  type: s2
- id: optional_volume
  type: u1
- id: bend_sensitivity_override
  type: u1
- id: field_0x5a
  type: dse_channel_field_0x5a_array
- id: envelope_override
  type: sound_envelope_parameters
- id: lfo_settings
  type: dse_channel_lfo_settings_array
- id: voice_list
  type: pointer
- id: held_notes_list
  type: pointer
- id: wavebank
  type: pointer
- id: instrument
  type: pointer
- id: synth
  type: pointer
