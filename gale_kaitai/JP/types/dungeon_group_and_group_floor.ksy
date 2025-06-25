doc: Represents a struct or union dungeon_group_and_group_floor defined within 
  pmdsky-debug.
meta:
  id: dungeon_group_and_group_floor
  endian: le
  bit-endian: le
  imports:
  - dungeon_group_id_8
seq:
- id: group_id
  type: dungeon_group_id_8
- id: group_floor
  type: u1
