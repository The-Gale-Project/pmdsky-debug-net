doc: Represents an array WRING_OUT_DAMAGE_MULT_TABLE defined within pmdsky.
meta:
  id: wring_out_damage_mult_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: wring_out_damage_mult_table_array_dim_0
types:
  wring_out_damage_mult_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 4
