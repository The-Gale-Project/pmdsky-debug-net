doc: Represents a struct or union partner_talk_kind_table_entry defined within 
  pmdsky-debug.
meta:
  id: partner_talk_kind_table_entry
  endian: le
  bit-endian: le
  imports:
  - talk_kind
  - monster_id
seq:
- id: talk_kind
  type: talk_kind
- id: id
  type: monster_id
