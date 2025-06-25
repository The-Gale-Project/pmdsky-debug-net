doc: Represents a struct or union action_parameter defined within pmdsky-debug.
meta:
  id: action_parameter
  endian: le
  bit-endian: le
  imports:
  - position
seq:
- id: action_use_idx
  type: u1
- id: field_0x1
  type: u1
- id: item_pos
  type: position
