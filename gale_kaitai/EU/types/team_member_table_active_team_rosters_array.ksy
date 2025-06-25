doc: Represents an array team_member_table_active_team_rosters defined within 
  pmdsky.
meta:
  id: team_member_table_active_team_rosters_array
  endian: le
  bit-endian: le
  imports:
  - team_member
seq:
- id: entries
  type: team_member_table_active_team_rosters_array_dim_1
types:
  team_member_table_active_team_rosters_array_dim_0:
    seq:
    - id: entries
      type: team_member
      repeat: expr
      repeat-expr: 4
  team_member_table_active_team_rosters_array_dim_1:
    seq:
    - id: entries
      type: team_member_table_active_team_rosters_array_dim_0
      repeat: expr
      repeat-expr: 3
