doc: Represents an array RECRUITMENT_TABLE_LEVELS defined within pmdsky.
meta:
  id: recruitment_table_levels_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: recruitment_table_levels_array_dim_0
types:
  recruitment_table_levels_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 22
