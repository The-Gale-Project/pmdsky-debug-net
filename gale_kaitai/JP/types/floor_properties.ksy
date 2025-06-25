doc: Represents a struct or union floor_properties defined within pmdsky-debug.
meta:
  id: floor_properties
  endian: le
  bit-endian: le
  imports:
  - floor_layout_8
  - weather_id_8
  - fixed_room_id_8
  - shop_item_positions_8
  - hidden_stairs_type
seq:
- id: layout
  type: floor_layout_8
- id: room_density
  type: s1
- id: tileset
  type: u1
- id: music_table_idx
  type: u1
- id: weather
  type: weather_id_8
- id: floor_connectivity
  type: u1
- id: enemy_density
  type: u1
- id: kecleon_shop_spawn_chance
  type: u1
- id: monster_house_spawn_chance
  type: u1
- id: maze_room_chance
  type: u1
- id: sticky_item_chance
  type: u1
- id: allow_dead_ends
  type: u1
- id: max_secondary_structures
  type: u1
- id: f_secondary_structures
  type: b1
- id: room_flags_unk1
  type: b1
- id: f_room_imperfections
  type: b1
- id: room_flags_unk3
  type: b5
- id: field_0xe
  type: u1
- id: item_density
  type: u1
- id: trap_density
  type: u1
- id: floor_number
  type: u1
- id: fixed_room_id
  type: fixed_room_id_8
- id: extra_hallways
  type: u1
- id: buried_item_density
  type: u1
- id: secondary_terrain_density
  type: u1
- id: visibility_range
  type: u1
- id: max_money_amount_div_5
  type: u1
- id: shop_item_positions
  type: shop_item_positions_8
- id: itemless_monster_house_chance
  type: u1
- id: hidden_stairs_type
  type: hidden_stairs_type
- id: hidden_stairs_spawn_chance
  type: u1
- id: enemy_iq
  type: s2
- id: iq_booster_value
  type: s2
