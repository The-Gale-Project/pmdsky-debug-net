doc: Represents a struct or union fixed_room_properties_entry defined within 
  pmdsky-debug.
meta:
  id: fixed_room_properties_entry
  endian: le
  bit-endian: le
  imports:
  - music_id_16
seq:
- id: music
  type: music_id_16
- id: field_0x2
  type: u1
- id: field_0x3
  type: u1
- id: illuminated
  type: u1
- id: enable_lategame_traps
  type: u1
- id: moves_enabled
  type: u1
- id: orbs_allowed
  type: u1
- id: tile_jumps_allowed
  type: u1
- id: trawl_orbs_allowed
  type: u1
- id: exit_after_enemies_defeated
  type: u1
- id: field_0xb
  type: u1
