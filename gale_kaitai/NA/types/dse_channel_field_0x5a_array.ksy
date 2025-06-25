doc: Represents an array dse_channel_field_0x5A defined within pmdsky.
meta:
  id: dse_channel_field_0x5a_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_channel_field_0x5a_array_dim_0
types:
  dse_channel_field_0x5a_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 10
