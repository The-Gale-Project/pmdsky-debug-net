doc: Represents a struct or union dse_voice defined within pmdsky-debug.
meta:
  id: dse_voice
  endian: le
  bit-endian: le
  imports:
  - dse_sample
  - sound_envelope
  - dse_lfo_bank
  - dse_voice_field_0x14d_array
  - pointer
seq:
- id: allocated_sequence_id
  type: u4
- id: note_off_flag
  type: u2
- id: update_flags
  type: u2
- id: hw_voice_index
  type: u2
- id: hw_voice_bit
  type: u2
- id: field_0xc
  type: u1
- id: current_note_number
  type: u1
- id: wave_index
  type: s1
- id: key_bend_sensitivity
  type: u1
- id: key_bend
  type: s2
- id: note_key
  type: u2
- id: key_base
  type: s2
- id: note_volume
  type: u1
- id: wave_pan
  type: u1
- id: channel_and_keygroup
  type: u2
- id: field_0x1c
  type: u2
- id: sample
  type: dse_sample
- id: envelope
  type: sound_envelope
- id: lfo_bank
  type: dse_lfo_bank
- id: timer
  type: s4
- id: volume
  type: s4
- id: pan
  type: s4
- id: field_0x148
  type: u4
- id: envelope_volume
  type: u1
- id: field_0x14d
  type: dse_voice_field_0x14d_array
- id: next_in_channel_allocation_list
  type: pointer
- id: channel_allocation
  type: pointer
