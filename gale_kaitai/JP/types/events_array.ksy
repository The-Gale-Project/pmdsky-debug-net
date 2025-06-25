doc: Represents an array EVENTS defined within pmdsky.
meta:
  id: events_array
  endian: le
  bit-endian: le
  imports:
  - script_level
seq:
- id: entries
  type: events_array_dim_0
types:
  events_array_dim_0:
    seq:
    - id: entries
      type: script_level
      repeat: expr
      repeat-expr: 0
