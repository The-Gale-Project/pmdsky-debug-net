doc: Represents an array dse_file_header_field_0x10 defined within pmdsky.
meta:
  id: dse_file_header_field_0x10_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_file_header_field_0x10_array_dim_0
types:
  dse_file_header_field_0x10_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 16
