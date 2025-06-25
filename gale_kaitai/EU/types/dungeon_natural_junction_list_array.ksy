doc: Represents an array dungeon_natural_junction_list defined within pmdsky.
meta:
  id: dungeon_natural_junction_list_array
  endian: le
  bit-endian: le
  imports:
  - position
seq:
- id: entries
  type: dungeon_natural_junction_list_array_dim_1
types:
  dungeon_natural_junction_list_array_dim_0:
    seq:
    - id: entries
      type: position
      repeat: expr
      repeat-expr: 32
  dungeon_natural_junction_list_array_dim_1:
    seq:
    - id: entries
      type: dungeon_natural_junction_list_array_dim_0
      repeat: expr
      repeat-expr: 32
