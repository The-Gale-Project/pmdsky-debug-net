doc: Represents a struct or union sound_envelope_parameters defined within 
  pmdsky-debug.
meta:
  id: sound_envelope_parameters
  endian: le
  bit-endian: le
  imports: []
seq:
- id: use_envelope
  type: u1
- id: slide_time_multiplier
  type: u1
- id: field_0x2
  type: u2
- id: field_0x4
  type: u4
- id: attack_begin
  type: u1
- id: attack_time
  type: u1
- id: decay_time
  type: u1
- id: sustain_level
  type: u1
- id: hold_time
  type: u1
- id: sustain_time
  type: u1
- id: release_time
  type: u1
- id: field_0xe
  type: u1
