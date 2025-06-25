doc: Represents an array live_event_list_events defined within pmdsky.
meta:
  id: live_event_list_events_array
  endian: le
  bit-endian: le
  imports:
  - live_event
seq:
- id: entries
  type: live_event_list_events_array_dim_0
types:
  live_event_list_events_array_dim_0:
    seq:
    - id: entries
      type: live_event
      repeat: expr
      repeat-expr: 32
