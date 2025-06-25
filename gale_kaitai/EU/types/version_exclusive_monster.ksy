doc: Represents a struct or union version_exclusive_monster defined within 
  pmdsky-debug.
meta:
  id: version_exclusive_monster
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: id
  type: monster_id_16
- id: in_eot
  type: u1
- id: in_eod
  type: u1
