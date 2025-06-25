doc: Represents an array FX_ATAN_IDX_TABLE defined within pmdsky.
meta:
  id: fx_atan_idx_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: fx_atan_idx_table_array_dim_0
types:
  fx_atan_idx_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 129
