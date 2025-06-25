doc: Represents a struct or union render_type_and_flags defined within 
  pmdsky-debug.
meta:
  id: render_type_and_flags
  endian: le
  bit-endian: le
  imports:
  - render_type_3
seq:
- id: type
  type: render_type_3
- id: flags
  type: b13
