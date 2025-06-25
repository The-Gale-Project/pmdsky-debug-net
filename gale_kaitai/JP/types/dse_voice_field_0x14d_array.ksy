doc: Represents an array dse_voice_field_0x14D defined within pmdsky.
meta:
  id: dse_voice_field_0x14d_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_voice_field_0x14d_array_dim_0
types:
  dse_voice_field_0x14d_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 7
