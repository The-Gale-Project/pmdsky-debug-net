doc: Represents an array MOONLIGHT_HP_RESTORATION_TABLE defined within pmdsky.
meta:
  id: moonlight_hp_restoration_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: moonlight_hp_restoration_table_array_dim_0
types:
  moonlight_hp_restoration_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 8
