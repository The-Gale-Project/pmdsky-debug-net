doc: Represents an array monster_summary_active_statuses defined within pmdsky.
meta:
  id: monster_summary_active_statuses_array
  endian: le
  bit-endian: le
  imports:
  - status_id_8
seq:
- id: entries
  type: monster_summary_active_statuses_array_dim_0
types:
  monster_summary_active_statuses_array_dim_0:
    seq:
    - id: entries
      type: status_id_8
      repeat: expr
      repeat-expr: 30
