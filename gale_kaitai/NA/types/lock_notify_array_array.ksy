doc: Represents an array LOCK_NOTIFY_ARRAY defined within pmdsky.
meta:
  id: lock_notify_array_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: lock_notify_array_array_dim_0
types:
  lock_notify_array_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 20
