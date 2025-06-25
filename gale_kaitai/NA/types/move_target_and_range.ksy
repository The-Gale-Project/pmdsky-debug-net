doc: Represents a struct or union move_target_and_range defined within 
  pmdsky-debug.
meta:
  id: move_target_and_range
  endian: le
  bit-endian: le
  imports:
  - move_target_4
  - move_range_4
  - move_ai_condition_4
seq:
- id: target
  type: move_target_4
- id: range
  type: move_range_4
- id: ai_condition
  type: move_ai_condition_4
- id: unused
  type: b4
