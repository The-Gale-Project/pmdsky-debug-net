doc: Represents a struct or union wildcard_move_desc defined within 
  pmdsky-debug.
meta:
  id: wildcard_move_desc
  endian: le
  bit-endian: le
  imports:
  - move_id_16
  - pointer
seq:
- id: move_id
  type: move_id_16
- id: padding
  type: u2
- id: do_move
  type: pointer
