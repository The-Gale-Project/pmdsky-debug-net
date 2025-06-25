doc: Represents a struct or union dialogue_display_ctx defined within 
  pmdsky-debug.
meta:
  id: dialogue_display_ctx
  endian: le
  bit-endian: le
  imports:
  - dialogue_display_state
seq:
- id: field_0x0
  type: u1
- id: field_0x1
  type: u1
- id: field_0x2
  type: u1
- id: field_0x3
  type: u1
- id: display
  type: dialogue_display_state
