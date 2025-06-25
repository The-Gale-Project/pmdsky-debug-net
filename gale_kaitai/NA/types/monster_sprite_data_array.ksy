doc: Represents an array MONSTER_SPRITE_DATA defined within pmdsky.
meta:
  id: monster_sprite_data_array
  endian: le
  bit-endian: le
  imports:
  - monster_sprite_data_entry
seq:
- id: entries
  type: monster_sprite_data_array_dim_0
types:
  monster_sprite_data_array_dim_0:
    seq:
    - id: entries
      type: monster_sprite_data_entry
      repeat: expr
      repeat-expr: 600
