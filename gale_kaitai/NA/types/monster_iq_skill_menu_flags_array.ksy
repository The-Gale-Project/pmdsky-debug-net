doc: Represents an array monster_iq_skill_menu_flags defined within pmdsky.
meta:
  id: monster_iq_skill_menu_flags_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: monster_iq_skill_menu_flags_array_dim_0
types:
  monster_iq_skill_menu_flags_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 3
