doc: Represents an array dungeon_monster_house_item_weights defined within 
  pmdsky.
meta:
  id: dungeon_monster_house_item_weights_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_monster_house_item_weights_array_dim_0
types:
  dungeon_monster_house_item_weights_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 1416
