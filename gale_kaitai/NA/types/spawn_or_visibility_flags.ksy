doc: Represents a struct or union spawn_or_visibility_flags defined within 
  pmdsky-debug.
meta:
  id: spawn_or_visibility_flags
  endian: le
  bit-endian: le
  imports:
  - spawn_flags
  - visibility_flags
seq:
- id: spawn
  type: spawn_flags
- id: visibility
  type: visibility_flags
