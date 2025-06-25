doc: Represents an array GUEST_MONSTER_DATA defined within pmdsky.
meta:
  id: guest_monster_data_array
  endian: le
  bit-endian: le
  imports:
  - guest_monster
seq:
- id: entries
  type: guest_monster_data_array_dim_0
types:
  guest_monster_data_array_dim_0:
    seq:
    - id: entries
      type: guest_monster
      repeat: expr
      repeat-expr: 18
