doc: Represents an array dse_instrument_split_field_0xC defined within pmdsky.
meta:
  id: dse_instrument_split_field_0xc_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_instrument_split_field_0xc_array_dim_0
types:
  dse_instrument_split_field_0xc_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 8
