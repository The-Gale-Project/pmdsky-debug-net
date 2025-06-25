doc: Represents an array entity_table_hdr_active_monster_ptrs defined within 
  pmdsky.
meta:
  id: entity_table_hdr_active_monster_ptrs_array
  endian: le
  bit-endian: le
  imports:
  - pointer
seq:
- id: entries
  type: entity_table_hdr_active_monster_ptrs_array_dim_0
types:
  entity_table_hdr_active_monster_ptrs_array_dim_0:
    seq:
    - id: entries
      type: pointer
      repeat: expr
      repeat-expr: 20
