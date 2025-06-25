doc: Represents an array RECRUITMENT_LEVEL_BOOST_TABLE defined within pmdsky.
meta:
  id: recruitment_level_boost_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: recruitment_level_boost_table_array_dim_0
types:
  recruitment_level_boost_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 102
