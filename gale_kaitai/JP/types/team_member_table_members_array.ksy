doc: Represents an array team_member_table_members defined within pmdsky.
meta:
  id: team_member_table_members_array
  endian: le
  bit-endian: le
  imports:
  - ground_monster
seq:
- id: entries
  type: team_member_table_members_array_dim_0
types:
  team_member_table_members_array_dim_0:
    seq:
    - id: entries
      type: ground_monster
      repeat: expr
      repeat-expr: 555
