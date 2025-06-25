doc: Represents a struct or union main_ground_data defined within pmdsky-debug.
meta:
  id: main_ground_data
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: main_routine
  type: pointer
- id: partner_follow_data
  type: pointer
- id: actors
  type: pointer
- id: objects
  type: pointer
- id: performers
  type: pointer
- id: events
  type: pointer
