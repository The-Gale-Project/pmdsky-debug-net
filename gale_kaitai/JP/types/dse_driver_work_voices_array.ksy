doc: Represents an array dse_driver_work_voices defined within pmdsky.
meta:
  id: dse_driver_work_voices_array
  endian: le
  bit-endian: le
  imports:
  - dse_voice
seq:
- id: entries
  type: dse_driver_work_voices_array_dim_0
types:
  dse_driver_work_voices_array_dim_0:
    seq:
    - id: entries
      type: dse_voice
      repeat: expr
      repeat-expr: 16
