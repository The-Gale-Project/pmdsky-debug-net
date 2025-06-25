doc: Represents a struct or union dungeon_floor_pair defined within 
  pmdsky-debug.
meta:
  id: dungeon_floor_pair
  endian: le
  bit-endian: le
  imports:
  - dungeon_id_8
seq:
- id: dungeon_id
  type: dungeon_id_8
- id: floor_id
  type: u1
