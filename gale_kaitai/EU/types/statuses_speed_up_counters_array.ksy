doc: Represents an array statuses_speed_up_counters defined within pmdsky.
meta:
  id: statuses_speed_up_counters_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: statuses_speed_up_counters_array_dim_0
types:
  statuses_speed_up_counters_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 5
