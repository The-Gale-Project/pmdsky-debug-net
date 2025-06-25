doc: Represents a struct or union spawned_target_data defined within 
  pmdsky-debug.
meta:
  id: spawned_target_data
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
  - monster_behavior_8
  - position
seq:
- id: monster_id
  type: monster_id_16
- id: behavior
  type: monster_behavior_8
- id: padding_0x3
  type: u1
- id: level
  type: u2
- id: valid
  type: u1
- id: visible
  type: u1
- id: pos_assigned
  type: u1
- id: padding_0x9
  type: u1
- id: pos
  type: position
- id: field_0xe
  type: u1
