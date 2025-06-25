doc: Represents a struct or union live_event_list defined within pmdsky-debug.
meta:
  id: live_event_list
  endian: le
  bit-endian: le
  imports:
  - live_event_list_events_array
seq:
- id: events
  type: live_event_list_events_array
