doc: Represents an array dse_channel_lfo_settings defined within pmdsky.
meta:
  id: dse_channel_lfo_settings_array
  endian: le
  bit-endian: le
  imports:
  - dse_lfo_settings
seq:
- id: entries
  type: dse_channel_lfo_settings_array_dim_0
types:
  dse_channel_lfo_settings_array_dim_0:
    seq:
    - id: entries
      type: dse_lfo_settings
      repeat: expr
      repeat-expr: 4
