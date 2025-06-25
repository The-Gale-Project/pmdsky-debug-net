doc: Represents an array dse_sample_field_0x4 defined within pmdsky.
meta:
  id: dse_sample_field_0x4_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_sample_field_0x4_array_dim_0
types:
  dse_sample_field_0x4_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 5
