doc: Represents a struct or union fixed_room_action defined within pmdsky-debug.
meta:
  id: fixed_room_action
  endian: le
  bit-endian: le
  imports:
  - fixed_room_action_non_entity_8
seq:
- id: tile_action
  type: fixed_room_action_non_entity_8
- id: entity_action
  type: u1
