doc: Represents a struct or union dse_lfo_bank defined within pmdsky-debug.
meta:
  id: dse_lfo_bank
  endian: le
  bit-endian: le
  imports:
  - dse_lfo_bank_outputs_array
  - pointer
  - dse_lfo_bank_lfos_array
seq:
- id: outputs
  type: dse_lfo_bank_outputs_array
- id: lfo_list
  type: pointer
- id: lfos
  type: dse_lfo_bank_lfos_array
