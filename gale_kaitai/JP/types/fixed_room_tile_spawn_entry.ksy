doc: Represents a struct or union fixed_room_tile_spawn_entry defined within 
  pmdsky-debug.
meta:
  id: fixed_room_tile_spawn_entry
  endian: le
  bit-endian: le
  imports:
  - trap_id_8
seq:
- id: id
  type: trap_id_8
- id: flags
  type: u1
- id: room
  type: u1
- id: f_trap_visible
  type: b1
- id: flags3_unk1
  type: b2
- id: f_secondary_terrain
  type: b1
- id: flags3_unk4
  type: b4
