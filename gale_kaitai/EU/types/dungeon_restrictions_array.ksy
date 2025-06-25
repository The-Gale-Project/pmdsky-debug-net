doc: Represents an array DUNGEON_RESTRICTIONS defined within pmdsky.
meta:
  id: dungeon_restrictions_array
  endian: le
  bit-endian: le
  imports:
  - dungeon_restriction
seq:
- id: entries
  type: dungeon_restrictions_array_dim_0
types:
  dungeon_restrictions_array_dim_0:
    seq:
    - id: entries
      type: dungeon_restriction
      repeat: expr
      repeat-expr: 256
