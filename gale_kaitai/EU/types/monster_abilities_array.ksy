doc: Represents an array monster_abilities defined within pmdsky.
meta:
  id: monster_abilities_array
  endian: le
  bit-endian: le
  imports:
  - ability_id_8
seq:
- id: entries
  type: monster_abilities_array_dim_0
types:
  monster_abilities_array_dim_0:
    seq:
    - id: entries
      type: ability_id_8
      repeat: expr
      repeat-expr: 2
