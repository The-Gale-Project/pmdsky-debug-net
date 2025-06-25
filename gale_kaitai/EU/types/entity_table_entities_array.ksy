doc: Represents an array entity_table_entities defined within pmdsky.
meta:
  id: entity_table_entities_array
  endian: le
  bit-endian: le
  imports:
  - entity
seq:
- id: entries
  type: entity_table_entities_array_dim_0
types:
  entity_table_entities_array_dim_0:
    seq:
    - id: entries
      type: entity
      repeat: expr
      repeat-expr: 149
