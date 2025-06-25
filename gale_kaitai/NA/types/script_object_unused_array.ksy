doc: Represents an array script_object_unused defined within pmdsky.
meta:
  id: script_object_unused_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: script_object_unused_array_dim_0
types:
  script_object_unused_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 3
