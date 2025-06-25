doc: Represents an array TEX_START_ADDR_TABLE defined within pmdsky.
meta:
  id: tex_start_addr_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: tex_start_addr_table_array_dim_0
types:
  tex_start_addr_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 48
