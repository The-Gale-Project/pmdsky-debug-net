doc: Represents an array SPECIAL_EPISODE_MAIN_CHARACTERS defined within pmdsky.
meta:
  id: special_episode_main_characters_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: special_episode_main_characters_array_dim_0
types:
  special_episode_main_characters_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 100
