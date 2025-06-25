doc: Represents an array STRING_BALANCE_M_LEVEL_BIN defined within pmdsky.
meta:
  id: string_balance_m_level_bin_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: string_balance_m_level_bin_array_dim_0
types:
  string_balance_m_level_bin_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 20
