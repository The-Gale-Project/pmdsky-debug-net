doc: Represents an array LAST_RESORT_DAMAGE_MULT_TABLE defined within pmdsky.
meta:
  id: last_resort_damage_mult_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: last_resort_damage_mult_table_array_dim_0
types:
  last_resort_damage_mult_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 4
