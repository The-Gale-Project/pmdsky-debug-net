doc: Represents an array dse_se_bank_field_0x18 defined within pmdsky.
meta:
  id: dse_se_bank_field_0x18_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_se_bank_field_0x18_array_dim_0
types:
  dse_se_bank_field_0x18_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 4
