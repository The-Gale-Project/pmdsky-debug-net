doc: Represents a struct or union spawned_monster_data defined within 
  pmdsky-debug.
meta:
  id: spawned_monster_data
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
- id: field_0x3
  type: u1
- id: field_0x4
  type: u1
- id: field_0x5
  type: u1
- id: field_0x6
  type: u1
- id: field_0x7
  type: u1
- id: level
  type: u2
- id: pos
  type: position
- id: cannot_be_asleep
  type: u1
- id: field_0xf
  type: u1
