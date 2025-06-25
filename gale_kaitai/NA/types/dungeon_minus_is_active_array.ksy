doc: Represents an array dungeon_minus_is_active defined within pmdsky.
meta:
  id: dungeon_minus_is_active_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: dungeon_minus_is_active_array_dim_0
types:
  dungeon_minus_is_active_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 2
