doc: Represents a struct or union damage_source_16 defined within pmdsky-debug.
meta:
  id: damage_source_16
  endian: le
  bit-endian: le
  imports:
  - move_id_16
  - damage_source_non_move_16
seq:
- id: move
  type: move_id_16
- id: other
  type: damage_source_non_move_16
