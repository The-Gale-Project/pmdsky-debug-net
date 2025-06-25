doc: Represents an array MOBILITY_TYPE_TO_DUNGEON_MOBILITY_TYPE defined within 
  pmdsky.
meta:
  id: mobility_type_to_dungeon_mobility_type_array
  endian: le
  bit-endian: le
  imports:
  - mobility_type
seq:
- id: entries
  type: mobility_type_to_dungeon_mobility_type_array_dim_0
types:
  mobility_type_to_dungeon_mobility_type_array_dim_0:
    seq:
    - id: entries
      type: mobility_type
      repeat: expr
      repeat-expr: 8
