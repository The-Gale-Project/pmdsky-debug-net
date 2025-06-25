doc: Represents a struct or union dungeon_grid_cell defined within pmdsky-debug.
meta:
  id: dungeon_grid_cell
  endian: le
  bit-endian: le
  imports: []
seq:
- id: start_x
  type: s2
- id: start_y
  type: s2
- id: end_x
  type: s2
- id: end_y
  type: s2
- id: is_invalid
  type: u1
- id: has_secondary_structure
  type: u1
- id: is_room
  type: u1
- id: is_connected
  type: u1
- id: is_kecleon_shop
  type: u1
- id: field_0xd
  type: u1
- id: is_monster_house
  type: u1
- id: field_0xf
  type: u1
- id: is_maze_room
  type: u1
- id: was_merged_into_other_room
  type: u1
- id: is_merged_room
  type: u1
- id: is_connected_to_top
  type: u1
- id: is_connected_to_bottom
  type: u1
- id: is_connected_to_left
  type: u1
- id: is_connected_to_right
  type: u1
- id: should_connect_to_top
  type: u1
- id: should_connect_to_bottom
  type: u1
- id: should_connect_to_left
  type: u1
- id: should_connect_to_right
  type: u1
- id: field_0x1b
  type: u1
- id: flag_imperfect
  type: u1
- id: flag_secondary_structure
  type: u1
