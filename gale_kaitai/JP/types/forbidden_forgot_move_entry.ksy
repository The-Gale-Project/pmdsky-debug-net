doc: Represents a struct or union forbidden_forgot_move_entry defined within 
  pmdsky-debug.
meta:
  id: forbidden_forgot_move_entry
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
  - dungeon_id_16
  - move_id_16
seq:
- id: monster_id
  type: monster_id_16
- id: origin_id
  type: dungeon_id_16
- id: move_id
  type: move_id_16
