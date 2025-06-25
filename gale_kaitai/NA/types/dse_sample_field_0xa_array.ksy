doc: Represents an array dse_sample_field_0xA defined within pmdsky.
meta:
  id: dse_sample_field_0xa_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_sample_field_0xa_array_dim_0
types:
  dse_sample_field_0xa_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 10
