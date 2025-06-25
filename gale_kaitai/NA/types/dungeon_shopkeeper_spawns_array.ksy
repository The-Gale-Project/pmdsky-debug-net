doc: Represents an array dungeon_shopkeeper_spawns defined within pmdsky.
meta:
  id: dungeon_shopkeeper_spawns_array
  endian: le
  bit-endian: le
  imports:
  - spawned_shopkeeper_data
seq:
- id: entries
  type: dungeon_shopkeeper_spawns_array_dim_0
types:
  dungeon_shopkeeper_spawns_array_dim_0:
    seq:
    - id: entries
      type: spawned_shopkeeper_data
      repeat: expr
      repeat-expr: 8
