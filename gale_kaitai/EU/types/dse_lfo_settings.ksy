doc: Represents a struct or union dse_lfo_settings defined within pmdsky-debug.
meta:
  id: dse_lfo_settings
  endian: le
  bit-endian: le
  imports: []
seq:
- id: field_0x0
  type: u1
- id: type
  type: u1
- id: output_type
  type: u1
- id: lfo_waveform_index
  type: u1
- id: amplitude
  type: s4
- id: lfo_phase_change_msec
  type: u2
- id: msec_until_lfo_started
  type: u2
- id: lfo_envelope_len_msec
  type: u2
- id: unused
  type: u2
