doc: Represents an array dse_wave_field_0x0 defined within pmdsky.
meta:
  id: dse_wave_field_0x0_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_wave_field_0x0_array_dim_0
types:
  dse_wave_field_0x0_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 16
