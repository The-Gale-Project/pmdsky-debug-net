doc: Represents an array PARTNER_TALK_KIND_TABLE defined within pmdsky.
meta:
  id: partner_talk_kind_table_array
  endian: le
  bit-endian: le
  imports:
  - partner_talk_kind_table_entry
seq:
- id: entries
  type: partner_talk_kind_table_array_dim_0
types:
  partner_talk_kind_table_array_dim_0:
    seq:
    - id: entries
      type: partner_talk_kind_table_entry
      repeat: expr
      repeat-expr: 11
