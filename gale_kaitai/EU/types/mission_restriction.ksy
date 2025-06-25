doc: Represents a struct or union mission_restriction defined within 
  pmdsky-debug.
meta:
  id: mission_restriction
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
  - type_id_8
seq:
- id: monster_id
  type: monster_id_16
- id: type_id
  type: type_id_8
