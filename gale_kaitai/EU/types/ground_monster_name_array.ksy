doc: Represents an array ground_monster_name defined within pmdsky.
meta:
  id: ground_monster_name_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: ground_monster_name_array_dim_0
types:
  ground_monster_name_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 10
