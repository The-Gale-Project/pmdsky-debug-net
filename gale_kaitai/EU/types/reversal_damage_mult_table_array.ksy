doc: Represents an array REVERSAL_DAMAGE_MULT_TABLE defined within pmdsky.
meta:
  id: reversal_damage_mult_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: reversal_damage_mult_table_array_dim_0
types:
  reversal_damage_mult_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 4
