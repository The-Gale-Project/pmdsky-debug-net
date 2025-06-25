doc: Represents an array ROLLOUT_DAMAGE_MULT_TABLE defined within pmdsky.
meta:
  id: rollout_damage_mult_table_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: rollout_damage_mult_table_array_dim_0
types:
  rollout_damage_mult_table_array_dim_0:
    seq:
    - id: entries
      type: s4
      repeat: expr
      repeat-expr: 10
