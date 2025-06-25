doc: Represents an array monster_summary_iq_skill_flags defined within pmdsky.
meta:
  id: monster_summary_iq_skill_flags_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: monster_summary_iq_skill_flags_array_dim_0
types:
  monster_summary_iq_skill_flags_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 3
