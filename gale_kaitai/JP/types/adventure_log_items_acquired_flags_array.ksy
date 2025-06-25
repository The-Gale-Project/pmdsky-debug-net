doc: Represents an array adventure_log_items_acquired_flags defined within 
  pmdsky.
meta:
  id: adventure_log_items_acquired_flags_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: adventure_log_items_acquired_flags_array_dim_0
types:
  adventure_log_items_acquired_flags_array_dim_0:
    seq:
    - id: entries
      type: u4
      repeat: expr
      repeat-expr: 44
