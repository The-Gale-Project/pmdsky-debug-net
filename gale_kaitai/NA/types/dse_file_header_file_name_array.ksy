doc: Represents an array dse_file_header_file_name defined within pmdsky.
meta:
  id: dse_file_header_file_name_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dse_file_header_file_name_array_dim_0
types:
  dse_file_header_file_name_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 16
