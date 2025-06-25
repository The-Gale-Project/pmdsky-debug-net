doc: Represents an array dse_sequence_field_0x88 defined within pmdsky.
meta:
  id: dse_sequence_field_0x88_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_sequence_field_0x88_array_dim_0
types:
  dse_sequence_field_0x88_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 16
