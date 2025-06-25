doc: Represents a struct or union damage_source defined within pmdsky-debug.
meta:
  id: damage_source
  endian: le
  bit-endian: le
  imports:
  - move_id
  - damage_source_non_move
seq:
- id: move
  type: move_id
- id: other
  type: damage_source_non_move
