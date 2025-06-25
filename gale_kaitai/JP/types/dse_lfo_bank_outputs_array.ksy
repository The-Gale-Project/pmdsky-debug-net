doc: Represents an array dse_lfo_bank_outputs defined within pmdsky.
meta:
  id: dse_lfo_bank_outputs_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_lfo_bank_outputs_array_dim_0
types:
  dse_lfo_bank_outputs_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 6
