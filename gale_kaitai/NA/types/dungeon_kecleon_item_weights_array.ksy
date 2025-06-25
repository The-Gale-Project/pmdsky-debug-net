doc: Represents an array dungeon_kecleon_item_weights defined within pmdsky.
meta:
  id: dungeon_kecleon_item_weights_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_kecleon_item_weights_array_dim_0
types:
  dungeon_kecleon_item_weights_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 1416
