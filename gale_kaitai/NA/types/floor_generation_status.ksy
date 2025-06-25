doc: Represents a struct or union floor_generation_status defined within 
  pmdsky-debug.
meta:
  id: floor_generation_status
  endian: le
  bit-endian: le
  imports:
  - floor_size_8
  - position
  - floor_layout
  - hidden_stairs_type
seq:
- id: second_spawn
  type: u1
- id: has_monster_house
  type: u1
- id: stairs_room
  type: u1
- id: has_kecleon_shop
  type: u1
- id: has_chasms_as_secondary_terrain
  type: u1
- id: is_invalid
  type: u1
- id: floor_size
  type: floor_size_8
- id: has_maze
  type: u1
- id: no_enemy_spawns
  type: u1
- id: field_0x9
  type: u1
- id: field_0xa
  type: u1
- id: field_0xb
  type: u1
- id: kecleon_shop_spawn_chance
  type: s2
- id: field_0xe
  type: u1
- id: field_0xf
  type: u1
- id: monster_house_spawn_chance
  type: s2
- id: field_0x12
  type: u1
- id: field_0x13
  type: u1
- id: n_rooms
  type: s4
- id: secondary_structures_budget
  type: s4
- id: hidden_stairs_spawn
  type: position
- id: kecleon_shop_middle
  type: position
- id: n_tiles_reachable_from_stairs
  type: s4
- id: layout
  type: floor_layout
- id: hidden_stairs_type
  type: hidden_stairs_type
- id: kecleon_shop_min_x
  type: s4
- id: kecleon_shop_min_y
  type: s4
- id: kecleon_shop_max_x
  type: s4
- id: kecleon_shop_max_y
  type: s4
