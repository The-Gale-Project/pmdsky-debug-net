doc: Represents a struct or union dse_instrument_split defined within 
  pmdsky-debug.
meta:
  id: dse_instrument_split
  endian: le
  bit-endian: le
  imports:
  - dse_instrument_split_field_0xc_array
  - dse_instrument_split_field_0x1b_array
  - sound_envelope_parameters
seq:
- id: field_0x0
  type: u1
- id: index
  type: u1
- id: bend_sensitivity
  type: u1
- id: field_0x3
  type: u1
- id: min_note_num
  type: u1
- id: max_note_num
  type: u1
- id: field_0x6
  type: u1
- id: field_0x7
  type: u1
- id: min_note_volume
  type: u1
- id: max_note_volume
  type: u1
- id: field_0xc
  type: dse_instrument_split_field_0xc_array
- id: wave_index
  type: s2
- id: key_base
  type: s2
- id: field_0x16
  type: u1
- id: note_delta
  type: s1
- id: volume
  type: u1
- id: pan
  type: u1
- id: keygroup_index
  type: u1
- id: field_0x1b
  type: dse_instrument_split_field_0x1b_array
- id: envelope_params
  type: sound_envelope_parameters
