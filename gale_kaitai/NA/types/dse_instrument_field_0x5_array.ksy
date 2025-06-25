doc: Represents an array dse_instrument_field_0x5 defined within pmdsky.
meta:
  id: dse_instrument_field_0x5_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_instrument_field_0x5_array_dim_0
types:
  dse_instrument_field_0x5_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 11
