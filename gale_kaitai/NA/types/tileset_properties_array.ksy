doc: Represents an array TILESET_PROPERTIES defined within pmdsky.
meta:
  id: tileset_properties_array
  endian: le
  bit-endian: le
  imports:
  - tileset_property
seq:
- id: entries
  type: tileset_properties_array_dim_0
types:
  tileset_properties_array_dim_0:
    seq:
    - id: entries
      type: tileset_property
      repeat: expr
      repeat-expr: 199
