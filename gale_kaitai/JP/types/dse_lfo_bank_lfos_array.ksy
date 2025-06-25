doc: Represents an array dse_lfo_bank_lfos defined within pmdsky.
meta:
  id: dse_lfo_bank_lfos_array
  endian: le
  bit-endian: le
  imports:
  - dse_lfo
seq:
- id: entries
  type: dse_lfo_bank_lfos_array_dim_0
types:
  dse_lfo_bank_lfos_array_dim_0:
    seq:
    - id: entries
      type: dse_lfo
      repeat: expr
      repeat-expr: 4
