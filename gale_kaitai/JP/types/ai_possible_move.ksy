doc: Represents a struct or union ai_possible_move defined within pmdsky-debug.
meta:
  id: ai_possible_move
  endian: le
  bit-endian: le
  imports:
  - direction_id_8
seq:
- id: can_be_used
  type: u1
- id: direction
  type: direction_id_8
- id: field_0x2
  type: u1
- id: field_0x3
  type: u1
- id: weight
  type: s4
