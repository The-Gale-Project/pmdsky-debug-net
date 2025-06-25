doc: Represents an array ground_monster_iq_skill_flags defined within pmdsky.
meta:
  id: ground_monster_iq_skill_flags_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: ground_monster_iq_skill_flags_array_dim_0
types:
  ground_monster_iq_skill_flags_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 3
