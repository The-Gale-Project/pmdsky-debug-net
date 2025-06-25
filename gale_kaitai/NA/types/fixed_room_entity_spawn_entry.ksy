doc: Represents a struct or union fixed_room_entity_spawn_entry defined within 
  pmdsky-debug.
meta:
  id: fixed_room_entity_spawn_entry
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: item
  type: pointer
- id: monster
  type: pointer
- id: tile
  type: pointer
