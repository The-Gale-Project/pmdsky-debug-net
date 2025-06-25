doc: Represents an array dse_synth_channels defined within pmdsky.
meta:
  id: dse_synth_channels_array
  endian: le
  bit-endian: le
  imports:
  - dse_channel
seq:
- id: entries
  type: dse_synth_channels_array_dim_0
types:
  dse_synth_channels_array_dim_0:
    seq:
    - id: entries
      type: dse_channel
      repeat: eos
