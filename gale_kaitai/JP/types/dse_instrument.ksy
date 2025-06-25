doc: Represents a struct or union dse_instrument defined within pmdsky-debug.
meta:
  id: dse_instrument
  endian: le
  bit-endian: le
  imports:
  - dse_instrument_field_0x5_array
  - dse_lfo_settings
  - dse_instrument_field_0x20_array
  - dse_instrument_splits_array
seq:
- id: field_0x0
  type: u2
- id: num_splits
  type: u1
- id: field_0x3
  type: u1
- id: volume
  type: u1
- id: field_0x5
  type: dse_instrument_field_0x5_array
- id: lfo_settings
  type: dse_lfo_settings
- id: field_0x20
  type: dse_instrument_field_0x20_array
- id: splits
  type: dse_instrument_splits_array
