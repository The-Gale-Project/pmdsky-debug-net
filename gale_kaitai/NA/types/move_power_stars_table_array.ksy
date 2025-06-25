doc: Represents an array MOVE_POWER_STARS_TABLE defined within pmdsky.
meta:
  id: move_power_stars_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: move_power_stars_table_array_dim_0
types:
  move_power_stars_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 6
