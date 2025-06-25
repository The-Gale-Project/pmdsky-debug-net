doc: Represents an array OBJECTS defined within pmdsky.
meta:
  id: objects_array
  endian: le
  bit-endian: le
  imports:
  - script_object
seq:
- id: entries
  type: objects_array_dim_0
types:
  objects_array_dim_0:
    seq:
    - id: entries
      type: script_object
      repeat: expr
      repeat-expr: 0
