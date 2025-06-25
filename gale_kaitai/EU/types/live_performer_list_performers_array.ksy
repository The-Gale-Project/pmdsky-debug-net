doc: Represents an array live_performer_list_performers defined within pmdsky.
meta:
  id: live_performer_list_performers_array
  endian: le
  bit-endian: le
  imports:
  - live_performer
seq:
- id: entries
  type: live_performer_list_performers_array_dim_0
types:
  live_performer_list_performers_array_dim_0:
    seq:
    - id: entries
      type: live_performer
      repeat: expr
      repeat-expr: 16
