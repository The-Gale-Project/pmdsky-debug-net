doc: Represents an array MORNING_SUN_HP_RESTORATION_TABLE defined within pmdsky.
meta:
  id: morning_sun_hp_restoration_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: morning_sun_hp_restoration_table_array_dim_0
types:
  morning_sun_hp_restoration_table_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 8
