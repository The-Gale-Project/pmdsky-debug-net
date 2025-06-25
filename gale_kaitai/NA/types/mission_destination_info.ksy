doc: Represents a struct or union mission_destination_info defined within 
  pmdsky-debug.
meta:
  id: mission_destination_info
  endian: le
  bit-endian: le
  imports:
  - mission_type_8
  - item_id_16
  - monster_id_16
  - mission_destination_info_enemy_species_array
  - fixed_room_id_8
seq:
- id: is_destination_floor
  type: u1
- id: type
  type: mission_type_8
- id: subtype
  type: u1
- id: mission_job_list_idx
  type: u1
- id: item_to_retrieve
  type: item_id_16
- id: item_to_deliver
  type: item_id_16
- id: special_target_item
  type: item_id_16
- id: client
  type: monster_id_16
- id: rescue_target
  type: monster_id_16
- id: enemy_species
  type: mission_destination_info_enemy_species_array
- id: n_enemy_species
  type: u1
- id: field_0x15
  type: u1
- id: fixed_room_id
  type: fixed_room_id_8
- id: unk_mission_item_tracker1
  type: u1
- id: field_0x18
  type: u1
- id: field_0x19
  type: u1
- id: unk_mission_item_tracker2
  type: u1
- id: target_enemy_is_defeated
  type: u1
- id: fleeing_outlaw_tracker
  type: u1
- id: field_0x1d
  type: u1
