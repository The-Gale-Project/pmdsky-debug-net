doc: Represents a struct or union dungeon_generation_info defined within 
  pmdsky-debug.
meta:
  id: dungeon_generation_info
  endian: le
  bit-endian: le
  imports:
  - hidden_stairs_type
  - fixed_room_id_8
  - dungeon_generation_info_tiles_array
  - position
  - dungeon_generation_info_individual_team_spawn_positions_array
seq:
- id: force_create_monster_house
  type: u1
- id: locked_door_opened
  type: u1
- id: kecleon_shop_spawned
  type: u1
- id: unk_one_room_flag
  type: u1
- id: dough_seed_extra_poke_flag
  type: u1
- id: monster_house_room
  type: u1
- id: fixed_room_boss_tracker
  type: u1
- id: field_0x7
  type: u1
- id: hidden_stairs_type
  type: hidden_stairs_type
- id: hidden_floor_type
  type: hidden_stairs_type
- id: tileset_id
  type: s2
- id: music_table_idx
  type: u2
- id: staircase_visual_idx
  type: u2
- id: fixed_room_id
  type: fixed_room_id_8
- id: field_0x17
  type: u1
- id: field_0x18
  type: u1
- id: field_0x19
  type: u1
- id: floor_generation_attempts
  type: u2
- id: tiles
  type: dungeon_generation_info_tiles_array
- id: team_spawn_pos
  type: position
- id: stairs_pos
  type: position
- id: hidden_stairs_pos
  type: position
- id: individual_team_spawn_positions
  type: dungeon_generation_info_individual_team_spawn_positions_array
