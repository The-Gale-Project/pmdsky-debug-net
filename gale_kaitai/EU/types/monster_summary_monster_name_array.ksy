doc: Represents an array monster_summary_monster_name defined within pmdsky.
meta:
  id: monster_summary_monster_name_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: monster_summary_monster_name_array_dim_0
types:
  monster_summary_monster_name_array_dim_0:
    seq:
    - id: entries
      type: s1
      repeat: expr
      repeat-expr: 10
