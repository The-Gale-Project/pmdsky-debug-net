doc: Represents a struct or union dungeon_return_status defined within 
  pmdsky-debug.
meta:
  id: dungeon_return_status
  endian: le
  bit-endian: le
  imports: []
seq:
- id: flag
  type: u1
- id: padding
  type: u1
- id: string_id
  type: s2
