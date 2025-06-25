doc: Represents an array RECRUITMENT_TABLE_LOCATIONS defined within pmdsky.
meta:
  id: recruitment_table_locations_array
  endian: le
  bit-endian: le
  imports:
  - dungeon_id_16
seq:
- id: entries
  type: recruitment_table_locations_array_dim_0
types:
  recruitment_table_locations_array_dim_0:
    seq:
    - id: entries
      type: dungeon_id_16
      repeat: expr
      repeat-expr: 22
