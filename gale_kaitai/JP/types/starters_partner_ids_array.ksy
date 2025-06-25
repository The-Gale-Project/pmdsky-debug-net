doc: Represents an array STARTERS_PARTNER_IDS defined within pmdsky.
meta:
  id: starters_partner_ids_array
  endian: le
  bit-endian: le
  imports:
  - monster_id_16
seq:
- id: entries
  type: starters_partner_ids_array_dim_0
types:
  starters_partner_ids_array_dim_0:
    seq:
    - id: entries
      type: monster_id_16
      repeat: expr
      repeat-expr: 21
