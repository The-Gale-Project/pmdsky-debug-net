doc: Represents a struct or union entity_table defined within pmdsky-debug.
meta:
  id: entity_table
  endian: le
  bit-endian: le
  imports:
  - entity_table_hdr
  - entity_table_entities_array
seq:
- id: header
  type: entity_table_hdr
- id: entities
  type: entity_table_entities_array
