doc: Represents an array dse_swd_file_header_field_0x42 defined within pmdsky.
meta:
  id: dse_swd_file_header_field_0x42_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_swd_file_header_field_0x42_array_dim_0
types:
  dse_swd_file_header_field_0x42_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 4
