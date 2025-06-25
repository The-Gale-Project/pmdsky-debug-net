doc: Represents a struct or union dungeon_init defined within pmdsky-debug.
meta:
  id: dungeon_init
  endian: le
  bit-endian: le
  imports:
  - dungeon_id_8
  - dungeon_objective_8
  - dungeon_init_guest_pokemon_array
  - item_id_16
  - game_id
  - unk_dungeon_init
seq:
- id: id
  type: dungeon_id_8
- id: floor
  type: u1
- id: field_0x2
  type: u2
- id: field_0x4
  type: u1
- id: nonstory_flag
  type: u1
- id: recruiting_enabled
  type: u1
- id: force_disable_recruiting
  type: u1
- id: field_0x8
  type: u1
- id: field_0x9
  type: u1
- id: send_home_disabled
  type: u1
- id: hidden_land_flag
  type: u1
- id: skip_faint_animation_flag
  type: u1
- id: dungeon_objective
  type: dungeon_objective_8
- id: field_0xe
  type: s1
- id: has_guest_pokemon
  type: u1
- id: send_help_item
  type: u1
- id: show_rescues_left
  type: u1
- id: field_0x12
  type: u1
- id: field_0x13
  type: u1
- id: field_0x14
  type: u4
- id: prng_preseed_23_bit
  type: u4
- id: guest_pokemon
  type: dungeon_init_guest_pokemon_array
- id: field_0xa4
  type: u1
- id: field_0xa5
  type: u1
- id: field_0xa6
  type: u1
- id: field_0xa7
  type: u1
- id: help_item
  type: item_id_16
- id: field_0xaa
  type: u1
- id: field_0xab
  type: u1
- id: dungeon_game_version_id
  type: game_id
- id: field_0xb0
  type: u4
- id: field_0xb4
  type: u1
- id: field_0xb5
  type: u1
- id: field_0xb6
  type: u1
- id: field_0xb7
  type: u1
- id: field_0xb8
  type: u1
- id: field_0xb9
  type: u1
- id: field_0xba
  type: u1
- id: field_0xbb
  type: u1
- id: field_0xbc
  type: u4
- id: field_0xc0
  type: unk_dungeon_init
- id: field_0x1a8
  type: u1
- id: field_0x1a9
  type: u1
- id: field_0x1aa
  type: u1
- id: field_0x1ab
  type: u1
