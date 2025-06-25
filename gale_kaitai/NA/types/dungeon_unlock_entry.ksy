doc: Represents a struct or union dungeon_unlock_entry defined within 
  pmdsky-debug.
meta:
  id: dungeon_unlock_entry
  endian: le
  bit-endian: le
  imports:
  - dungeon_id_8
seq:
- id: dungeon_id
  type: dungeon_id_8
- id: scenario_balance_min
  type: u1
