doc: Represents an array dungeon_init_guest_pokemon defined within pmdsky.
meta:
  id: dungeon_init_guest_pokemon_array
  endian: le
  bit-endian: le
  imports:
  - ground_monster
seq:
- id: entries
  type: dungeon_init_guest_pokemon_array_dim_0
types:
  dungeon_init_guest_pokemon_array_dim_0:
    seq:
    - id: entries
      type: ground_monster
      repeat: expr
      repeat-expr: 2
