doc: Represents an array LFO_WAVEFORM_CALLBACKS defined within pmdsky.
meta:
  id: lfo_waveform_callbacks_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: lfo_waveform_callbacks_array_dim_0
types:
  lfo_waveform_callbacks_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 16
