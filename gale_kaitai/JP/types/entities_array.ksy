doc: Represents an array ENTITIES defined within pmdsky.
meta:
  id: entities_array
  endian: le
  bit-endian: le
  imports:
  - script_entity
seq:
- id: entries
  type: entities_array_dim_0
types:
  entities_array_dim_0:
    seq:
    - id: entries
      type: script_entity
      repeat: expr
      repeat-expr: 386
