doc: Represents an array team_member_iq_skill_flags defined within pmdsky.
meta:
  id: team_member_iq_skill_flags_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: team_member_iq_skill_flags_array_dim_0
types:
  team_member_iq_skill_flags_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 3
