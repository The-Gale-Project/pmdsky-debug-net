doc: Represents a struct or union dse_se_bank defined within pmdsky-debug.
meta:
  id: dse_se_bank
  endian: le
  bit-endian: le
  imports:
  - pointer
  - dse_se_bank_field_0x18_array
seq:
- id: file
  type: pointer
- id: field_0x4
  type: s2
- id: id
  type: u2
- id: next
  type: pointer
- id: seq_location
  type: pointer
- id: mcrl_location
  type: pointer
- id: bnkl_location
  type: pointer
- id: field_0x18
  type: dse_se_bank_field_0x18_array
