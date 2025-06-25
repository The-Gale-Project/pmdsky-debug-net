doc: Represents a struct or union portrait_layout defined within pmdsky-debug.
meta:
  id: portrait_layout
  endian: le
  bit-endian: le
  imports: []
seq:
- id: offset_x
  type: s2
- id: offset_y
  type: s2
- id: try_flip
  type: u1
- id: padding
  type: u1
