doc: Represents an array STATUS_ICON_ARRAY_LEECH_SEED defined within pmdsky.
meta:
  id: status_icon_array_leech_seed_array
  endian: le
  bit-endian: le
  imports:
  - status_icon_flags
seq:
- id: entries
  type: status_icon_array_leech_seed_array_dim_0
types:
  status_icon_array_leech_seed_array_dim_0:
    seq:
    - id: entries
      type: status_icon_flags
      repeat: expr
      repeat-expr: 3
