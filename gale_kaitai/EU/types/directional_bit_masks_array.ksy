doc: Represents an array DIRECTIONAL_BIT_MASKS defined within pmdsky.
meta:
  id: directional_bit_masks_array
  endian: le
  bit-endian: le
seq:
- id: entries
  type: directional_bit_masks_array_dim_0
types:
  directional_bit_masks_array_dim_0:
    seq:
    - id: entries
      type: u1
      repeat: expr
      repeat-expr: 8
