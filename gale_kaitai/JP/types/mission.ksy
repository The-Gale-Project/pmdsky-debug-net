doc: Represents a struct or union mission defined within pmdsky-debug.
meta:
  id: mission
  endian: le
  bit-endian: le
  imports:
  - mission_status_8
  - mission_type_8
  - mission_subtype
  - dungeon_id_8
  - monster_id_16
  - item_id_16
  - mission_reward_type_8
  - mission_restriction_type_8
  - mission_restriction
seq:
- id: status
  type: mission_status_8
- id: type
  type: mission_type_8
- id: subtype
  type: mission_subtype
- id: field_0x3
  type: u1
- id: dungeon_id
  type: dungeon_id_8
- id: floor
  type: u1
- id: field_0x6
  type: u1
- id: field_0x7
  type: u1
- id: description_id
  type: s4
- id: unique_map_id
  type: u1
- id: field_0xd
  type: u1
- id: client
  type: monster_id_16
- id: target
  type: monster_id_16
- id: outlaw_backup_species
  type: monster_id_16
- id: item_wanted
  type: item_id_16
- id: reward_type
  type: mission_reward_type_8
- id: field_0x17
  type: u1
- id: item_reward
  type: item_id_16
- id: restriction_type
  type: mission_restriction_type_8
- id: field_0x1b
  type: u1
- id: restriction
  type: mission_restriction
- id: field_0x1e
  type: u1
- id: field_0x1f
  type: u1
