doc: Represents an array ERUPTION_DAMAGE_MULT_TABLE defined within pmdsky.
meta:
  id: eruption_damage_mult_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: eruption_damage_mult_table_array_dim_0
types:
  eruption_damage_mult_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 4
