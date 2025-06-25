doc: Represents an array monster_types defined within pmdsky.
meta:
  id: monster_types_array
  endian: le
  bit-endian: le
  imports:
  - type_id_8
seq:
- id: entries
  type: monster_types_array_dim_0
types:
  monster_types_array_dim_0:
    seq:
    - id: entries
      type: type_id_8
      repeat: expr
      repeat-expr: 2
