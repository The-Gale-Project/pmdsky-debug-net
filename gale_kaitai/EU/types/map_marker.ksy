doc: Represents a struct or union map_marker defined within pmdsky-debug.
meta:
  id: map_marker
  endian: le
  bit-endian: le
  imports:
  - position
seq:
- id: map_id
  type: u2
- id: reference_id
  type: s2
- id: pos
  type: position
