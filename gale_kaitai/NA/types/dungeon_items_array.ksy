doc: Represents an array dungeon_items defined within pmdsky.
meta:
  id: dungeon_items_array
  endian: le
  bit-endian: le
  imports:
  - item
seq:
- id: entries
  type: dungeon_items_array_dim_0
types:
  dungeon_items_array_dim_0:
    seq:
    - id: entries
      type: item
      repeat: expr
      repeat-expr: 64
