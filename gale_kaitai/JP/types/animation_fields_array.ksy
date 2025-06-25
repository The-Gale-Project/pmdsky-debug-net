doc: Represents an array animation_fields defined within pmdsky.
meta:
  id: animation_fields_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: animation_fields_array_dim_0
types:
  animation_fields_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 60
