doc: Represents an array ROOST_HP_RESTORATION_TABLE defined within pmdsky.
meta:
  id: roost_hp_restoration_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: roost_hp_restoration_table_array_dim_0
types:
  roost_hp_restoration_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 8
