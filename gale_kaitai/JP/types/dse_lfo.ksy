doc: Represents a struct or union dse_lfo defined within pmdsky-debug.
meta:
  id: dse_lfo
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: phase_flags
  type: u1
- id: type
  type: u1
- id: voice_update_flags
  type: u2
- id: ticks_per_phase_change
  type: u2
- id: ticks_until_phase_change
  type: u2
- id: current_output
  type: s4
- id: amplitude
  type: s4
- id: field_0x10
  type: u4
- id: output_delta
  type: s4
- id: field_0x18
  type: u2
- id: ticks_until_lfo_started
  type: u2
- id: field_0x1c
  type: u2
- id: lfo_envelope_ticks_left
  type: u2
- id: envelope_level
  type: s4
- id: envelope_delta
  type: s4
- id: output_ptr
  type: pointer
- id: waveform_callback
  type: pointer
- id: next
  type: pointer
