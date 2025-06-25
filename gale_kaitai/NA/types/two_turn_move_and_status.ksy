doc: Represents a struct or union two_turn_move_and_status defined within 
  pmdsky-debug.
meta:
  id: two_turn_move_and_status
  endian: le
  bit-endian: le
  imports:
  - move_id_16
  - status_two_turn_id_16
seq:
- id: move
  type: move_id_16
- id: status
  type: status_two_turn_id_16
