doc: Represents an array dse_instrument_splits defined within pmdsky.
meta:
  id: dse_instrument_splits_array
  endian: le
  bit-endian: le
  imports:
  - dse_instrument_split
seq:
- id: entries
  type: dse_instrument_splits_array_dim_0
types:
  dse_instrument_splits_array_dim_0:
    seq:
    - id: entries
      type: dse_instrument_split
      repeat: eos
