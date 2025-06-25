doc: Represents an array monster_stat_modifiers_offensive_stages defined within 
  pmdsky.
meta:
  id: monster_stat_modifiers_offensive_stages_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: monster_stat_modifiers_offensive_stages_array_dim_0
types:
  monster_stat_modifiers_offensive_stages_array_dim_0:
    seq:
    - id: entries
      type: s2
      repeat: expr
      repeat-expr: 2
