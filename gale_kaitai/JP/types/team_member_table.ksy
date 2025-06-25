doc: Represents a struct or union team_member_table defined within pmdsky-debug.
meta:
  id: team_member_table
  endian: le
  bit-endian: le
  imports:
  - team_member_table_members_array
  - team_member_table_active_team_rosters_array
  - pointer
  - team_member_table_active_team_roster_member_idxs_array
  - team_id_8
  - team_member_table_explorer_maze_team_name_array
  - team_member_table_explorer_maze_monsters_array
seq:
- id: members
  type: team_member_table_members_array
- id: active_team_rosters
  type: team_member_table_active_team_rosters_array
- id: active_roster
  type: pointer
- id: number_active_team_members_main
  type: s2
- id: number_active_team_members_se
  type: s2
- id: number_active_team_members_rescue
  type: s2
- id: active_team_roster_member_idxs
  type: team_member_table_active_team_roster_member_idxs_array
- id: field_0x986e
  type: u1
- id: field_0x986f
  type: u1
- id: active_roster_member_idxs
  type: pointer
- id: field_0x9874
  type: u1
- id: field_0x9875
  type: u1
- id: field_0x9876
  type: u1
- id: active_team
  type: team_id_8
- id: field_0x9878
  type: u4
- id: field_0x987c
  type: u4
- id: explorer_maze_team_native_language
  type: s1
- id: field_0x9881
  type: u1
- id: explorer_maze_team_name
  type: team_member_table_explorer_maze_team_name_array
- id: field_0x9896
  type: u1
- id: field_0x9897
  type: u1
- id: explorer_maze_monsters
  type: team_member_table_explorer_maze_monsters_array
