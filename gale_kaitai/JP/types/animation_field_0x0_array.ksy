doc: Represents an array animation_field_0x0 defined within pmdsky.
meta:
  id: animation_field_0x0_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: animation_field_0x0_array_dim_0
types:
  animation_field_0x0_array_dim_0:
    seq:
    - id: entries
      type: u2
      repeat: expr
      repeat-expr: 6
