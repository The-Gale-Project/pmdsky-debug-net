doc: Represents an array WATER_SPOUT_DAMAGE_MULT_TABLE defined within pmdsky.
meta:
  id: water_spout_damage_mult_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: water_spout_damage_mult_table_array_dim_0
types:
  water_spout_damage_mult_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 4
