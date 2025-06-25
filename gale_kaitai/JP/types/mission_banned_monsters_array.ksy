doc: Represents an array MISSION_BANNED_MONSTERS defined within pmdsky.
meta:
  id: mission_banned_monsters_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: mission_banned_monsters_array_dim_0
types:
  mission_banned_monsters_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 124
