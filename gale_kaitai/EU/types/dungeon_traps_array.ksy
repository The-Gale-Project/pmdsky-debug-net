doc: Represents an array dungeon_traps defined within pmdsky.
meta:
  id: dungeon_traps_array
  endian: le
  bit-endian: le
  imports:
  - trap
seq:
- id: entries
  type: dungeon_traps_array_dim_0
types:
  dungeon_traps_array_dim_0:
    seq:
    - id: entries
      type: trap
      repeat: expr
      repeat-expr: 64
