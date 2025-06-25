doc: Represents a struct or union spawned_shopkeeper_data defined within 
  pmdsky-debug.
meta:
  id: spawned_shopkeeper_data
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
  - monster_behavior_8
seq:
- id: monster_id
  type: monster_id_16
- id: behavior
  type: monster_behavior_8
- id: valid
  type: u1
- id: pos_x
  type: u1
- id: pos_y
  type: u1
