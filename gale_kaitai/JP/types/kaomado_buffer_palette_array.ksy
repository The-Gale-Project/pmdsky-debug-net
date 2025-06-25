doc: Represents an array kaomado_buffer_palette defined within pmdsky.
meta:
  id: kaomado_buffer_palette_array
  endian: le
  bit-endian: le
  imports:
  - rgb
seq:
- id: entries
  type: kaomado_buffer_palette_array_dim_0
types:
  kaomado_buffer_palette_array_dim_0:
    seq:
    - id: entries
      type: rgb
      repeat: expr
      repeat-expr: 16
