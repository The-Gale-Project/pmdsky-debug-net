doc: Represents a struct or union tile defined within pmdsky-debug.
meta:
  id: tile
  endian: le
  bit-endian: le
  imports:
  - terrain_type_2
  - spawn_or_visibility_flags
  - tile_walkable_neighbor_flags_array
  - pointer
seq:
- id: terrain_type
  type: terrain_type_2
- id: f_corner_cuttable
  type: b1
- id: f_natural_junction
  type: b1
- id: f_impassable_wall
  type: b1
- id: f_in_kecleon_shop
  type: b1
- id: f_in_monster_house
  type: b1
- id: terrain_flags_unk7
  type: b1
- id: f_unbreakable
  type: b1
- id: f_stairs
  type: b1
- id: terrain_flags_unk10
  type: b1
- id: f_key_door
  type: b1
- id: f_key_door_key_locked
  type: b1
- id: f_key_door_escort_locked
  type: b1
- id: terrain_flags_unk14
  type: b1
- id: f_unreachable_from_stairs
  type: b1
- id: spawn_or_visibility_flags
  type: spawn_or_visibility_flags
- id: texture_id
  type: u2
- id: field_0x6
  type: u1
- id: room
  type: u1
- id: walkable_neighbor_flags
  type: tile_walkable_neighbor_flags_array
- id: monster
  type: pointer
- id: object
  type: pointer
