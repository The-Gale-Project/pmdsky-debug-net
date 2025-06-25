doc: Represents a struct or union sound_envelope defined within pmdsky-debug.
meta:
  id: sound_envelope
  endian: le
  bit-endian: le
  imports:
  - sound_envelope_parameters
seq:
- id: parameters
  type: sound_envelope_parameters
- id: current_volume
  type: s4
- id: volume_delta
  type: s4
- id: ticks_left
  type: s4
- id: state
  type: u1
- id: target_volume
  type: u1
- id: update_volume
  type: u1
- id: unused
  type: u1
