doc: Represents an array STARTERS_HERO_IDS defined within pmdsky.
meta:
  id: starters_hero_ids_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: starters_hero_ids_array_dim_0
types:
  starters_hero_ids_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 32
